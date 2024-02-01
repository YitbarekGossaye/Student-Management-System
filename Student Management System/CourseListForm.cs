using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class CourseListForm : Form
    {


        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private DataSet courseDataSet;
        private SqlDataAdapter courseAdapter;
        public CourseListForm()
        {
            InitializeComponent();
            InitializeDataSet();
            InitializeDataAdapter();
            LoadCourses();
            DisplayTotalCourses();
        }
        private void InitializeDataSet()
        {
            courseDataSet = new DataSet();
            DataTable coursesDataTable = new DataTable("Courses");

            coursesDataTable.Columns.Add("CourseID", typeof(string));
            coursesDataTable.Columns.Add("CourseName", typeof(string));
            coursesDataTable.Columns.Add("CreditHour", typeof(int));
            coursesDataTable.Columns.Add("DepartmentID", typeof(string));

            coursesDataTable.PrimaryKey = new DataColumn[] { coursesDataTable.Columns["CourseID"] };

            courseDataSet.Tables.Add(coursesDataTable);
        }
        private void InitializeDataAdapter()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    courseAdapter = new SqlDataAdapter("SELECT * FROM Course", connection);

                    SqlCommandBuilder builder = new SqlCommandBuilder(courseAdapter);

                    courseAdapter.InsertCommand = builder.GetInsertCommand();
                    courseAdapter.UpdateCommand = builder.GetUpdateCommand();
                    courseAdapter.DeleteCommand = builder.GetDeleteCommand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing data adapter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCourses()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Course", connection);

                    courseDataSet.Tables["Courses"].Clear();
                    adapter.Fill(courseDataSet.Tables["Courses"]);

                    dataGridViewCourseList.DataSource = courseDataSet.Tables["Courses"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTotalCourses()
        {
            int totalCourses = dataGridViewCourseList.Rows.Count;
            labelTotalcourse.Text = $"{totalCourses}";
        }
        private void dataGridViewCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotalcourse_Click(object sender, EventArgs e)
        {

        }
        private void DeleteSelectedCourseBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dataGridViewCourseList.SelectedRows)
                        {
                            string courseID = row.Cells["CourseID"].Value.ToString();

                            SqlCommand deleteCourseCommand = new SqlCommand($"DELETE FROM Course WHERE CourseID = '{courseID}'", connection);
                            deleteCourseCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Course(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
                        DisplayTotalCourses();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateSelectedbutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewCourseList.SelectedRows[0];

                // Extract the courseID from the selected row
                string courseID = selectedRow.Cells["CourseID"].Value.ToString();
                string departmentID = selectedRow.Cells["CourseID"].Value.ToString();

                // Call the method to update the selected course
                OpenUpdateCourseForm(courseID, departmentID);
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenUpdateCourseForm(string courseID,string  departmentID)
        {
            // Open the UpdateCourseForm and pass the courseID
            UpdateDeleteCourseForm updateForm = new UpdateDeleteCourseForm(courseID, departmentID);

            // Display the UpdateCourseForm
            updateForm.ShowDialog();

            // Reload courses after update
            LoadCourses();
            DisplayTotalCourses();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            // Open the AddCourseForm
            AddCourseForm addForm = new AddCourseForm();

            // Display the AddCourseForm
            addForm.ShowDialog();

            // Reload courses after addition
            LoadCourses();
            DisplayTotalCourses();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
