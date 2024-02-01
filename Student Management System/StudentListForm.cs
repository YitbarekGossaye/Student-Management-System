using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Student_Management_System
{
    public partial class StudentListForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private DataSet studentDataSet;
        private SqlDataAdapter studentAdapter;
        private bool dataGridChanged = false;

        public StudentListForm()
        {
            InitializeComponent();
            InitializeDataSet();
            InitializeDataAdapter();
            DisplayTotalStudents();
            DisplayGenderCounts();

            dataGridViewStudentList.CellValueChanged += dataGridViewStudentList_CellValueChanged;
        }
        private void InitializeDataSet()
        {
            // Initialize the DataSet and add a DataTable for Students
            studentDataSet = new DataSet();
            DataTable studentsDataTable = new DataTable("Students");

            // Add columns to the DataTable (adjust column types as needed)
            studentsDataTable.Columns.Add("Username", typeof(string));
            studentsDataTable.Columns.Add("FirstName", typeof(string));
            studentsDataTable.Columns.Add("LastName", typeof(string));
            studentsDataTable.Columns.Add("Sex", typeof(string));
            studentsDataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            studentsDataTable.Columns.Add("DepartmentID", typeof(string));
            studentsDataTable.Columns.Add("Year", typeof(int));
            studentsDataTable.Columns.Add("Email", typeof(string));
            studentsDataTable.Columns.Add("Password", typeof(string));
            studentsDataTable.Columns.Add("ProfileImage", typeof(byte[]));

            // Set the primary key for the DataTable
            studentsDataTable.PrimaryKey = new DataColumn[] { studentsDataTable.Columns["Username"] };

            // Add the DataTable to the DataSet
            studentDataSet.Tables.Add(studentsDataTable);
        }
        private void InitializeDataAdapter()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the SqlDataAdapter and associate it with the Students table
                    studentAdapter = new SqlDataAdapter("SELECT * FROM Students", connection);

                    // Initialize the SqlCommandBuilder for automatic command generation
                    SqlCommandBuilder builder = new SqlCommandBuilder(studentAdapter);

                    // Set the Insert, Update, and Delete commands for the DataAdapter
                    studentAdapter.InsertCommand = builder.GetInsertCommand();
                    studentAdapter.UpdateCommand = builder.GetUpdateCommand();
                    studentAdapter.DeleteCommand = builder.GetDeleteCommand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing data adapter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", connection);

                    // Clear existing data in the DataTable
                    studentDataSet.Tables["Students"].Clear();

                    // Fill the DataTable with data from the database
                    adapter.Fill(studentDataSet.Tables["Students"]);

                    // Set the DataGridView's DataSource to the DataTable
                    dataGridViewStudentList.DataSource = studentDataSet.Tables["Students"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayTotalStudents()
        {
            int totalStudents = studentDataSet.Tables["Students"].Rows.Count;
            labelTotalStudent.Text = $"{totalStudents}";
        }

        private void DisplayGenderCounts()
        {
            int totalMaleStudents = studentDataSet.Tables["Students"].Select("Sex = 'Male'").Length;
            int totalFemaleStudents = studentDataSet.Tables["Students"].Select("Sex = 'Female'").Length;

            labelTotalMaleStudent.Text = $"{totalMaleStudents}";
            labelTotalFemaleStudent.Text = $"{totalFemaleStudents}";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotalStudent_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalMaleStudent_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalFemaleStudent_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedStudentBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentList.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dataGridViewStudentList.SelectedRows)
                        {
                            string username = row.Cells["Username"].Value.ToString();

                            // Delete from Students table
                            SqlCommand deleteStudentCommand = new SqlCommand($"DELETE FROM Students WHERE Username = '{username}'", connection);
                            deleteStudentCommand.ExecuteNonQuery();

                            // Delete from Users table
                            SqlCommand deleteUserCommand = new SqlCommand($"DELETE FROM Users WHERE Username = '{username}'", connection);
                            deleteUserCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Student(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                        DisplayTotalStudents();
                        DisplayGenderCounts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateSelectedStudentBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewStudentList.SelectedRows[0];

                // Extract the username from the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();

                // Call the method to update the selected student
                OpenUpdateStudentForm(username);
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OpenUpdateStudentForm(string username)
        {
            // Open the UpdateStudentForm and pass the username
            UpdateStudentForm updateForm = new UpdateStudentForm(username);

            // Display the UpdateStudentForm
            updateForm.ShowDialog();
            LoadStudents();
            DisplayTotalStudents();
            DisplayGenderCounts();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addForm = new AddNewStudentForm();
            addForm.ShowDialog();
            LoadStudents();
            DisplayTotalStudents();
            DisplayGenderCounts();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewStudentList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridChanged = true;

        }
        private bool IsUsernameAlreadyExists(SqlConnection connection, string username)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Username = @Username", connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            DisplayTotalStudents();
            DisplayGenderCounts();
        }
    }
}
