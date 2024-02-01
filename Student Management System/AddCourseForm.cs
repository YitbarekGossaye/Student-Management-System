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
    public partial class AddCourseForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";

        public AddCourseForm()
        {
            InitializeComponent();
            LoadDepartmentIDs();
        }
     

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtextBoxCourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtextBoxCourseHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve course information from the text boxes and combo box
                string courseID = textBoxtextBoxCourseID.Text.Trim();
                string courseName = textBoxCourseName.Text.Trim();
                int creditHour;

                // Check if creditHour is not empty
                if (!int.TryParse(textBoxtextBoxCourseHr.Text, out creditHour))
                {
                    MessageBox.Show("Please enter a valid Credit Hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string departmentID = comboBoxDepartmentID.SelectedValue.ToString();

                // Validate input (ensure required fields are not empty)
                if (string.IsNullOrEmpty(courseID) || string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(departmentID))
                {
                    MessageBox.Show("Please enter Course ID, Course Name, and select a Department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the course ID and department ID combination is unique
                if (!IsCourseIDDepartmentIDUnique(courseID, departmentID))
                {
                    MessageBox.Show("Course ID already exists for the selected Department. Please choose a different Course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert new course into the Course table using a SqlCommand
                    string insertQuery = "INSERT INTO Course (CourseID, CourseName, CreditHour, DepartmentID) VALUES (@CourseID, @CourseName, @CreditHour, @DepartmentID)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@CourseID", courseID);
                        insertCommand.Parameters.AddWithValue("@CourseName", courseName);
                        insertCommand.Parameters.AddWithValue("@CreditHour", creditHour);
                        insertCommand.Parameters.AddWithValue("@DepartmentID", departmentID);

                        // Execute the insert query
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the text boxes for the next entry
                            textBoxtextBoxCourseID.Text = "";
                            textBoxCourseName.Text = "";
                            textBoxtextBoxCourseHr.Text = "";
                            comboBoxDepartmentID.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Error adding course. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void LoadDepartmentIDs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch department IDs from the Department table using a DataSet
                    string query = "SELECT DeptID FROM Departments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Departments");

                    // Bind the department IDs to the comboBoxDepartmentID
                    comboBoxDepartmentID.DataSource = ds.Tables["Departments"];
                    comboBoxDepartmentID.DisplayMember = "DeptID";
                    comboBoxDepartmentID.ValueMember = "DeptID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading department IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsCourseIDDepartmentIDUnique(string courseID, string departmentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the course ID and department ID combination already exists using a DataSet
                    string checkQuery = "SELECT COUNT(*) FROM Course WHERE CourseID = @CourseID AND DepartmentID = @DepartmentID";
                    SqlDataAdapter checkAdapter = new SqlDataAdapter(checkQuery, connection);
                    checkAdapter.SelectCommand.Parameters.AddWithValue("@CourseID", courseID);
                    checkAdapter.SelectCommand.Parameters.AddWithValue("@DepartmentID", departmentID);
                    DataSet checkDS = new DataSet();
                    checkAdapter.Fill(checkDS, "Course");

                    int count = Convert.ToInt32(checkDS.Tables["Course"].Rows[0][0]);

                    return count == 0; // If count is 0, the combination is unique
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking uniqueness: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false in case of an error
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
