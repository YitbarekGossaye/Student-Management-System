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
    public partial class UpdateDeleteCourseForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private readonly string courseIDToUpdate;
        private readonly string departmentIDToUpdate;

        public UpdateDeleteCourseForm(string courseID, string departmentID)
        {
            InitializeComponent();
            courseIDToUpdate = courseID;
            departmentIDToUpdate = departmentID;
            LoadCourseInformation();
        }
        private void LoadCourseInformation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch department IDs from the Department table using a DataSet
                    string departmentsQuery = "SELECT DeptID FROM Departments";
                    SqlDataAdapter departmentsAdapter = new SqlDataAdapter(departmentsQuery, connection);
                    DataSet departmentsDS = new DataSet();
                    departmentsAdapter.Fill(departmentsDS, "Departments");

                    // Bind the department IDs to the comboBoxDepartmentID
                    comboBoxDepartmentID.DataSource = departmentsDS.Tables["Departments"];
                    comboBoxDepartmentID.DisplayMember = "DeptID";
                    comboBoxDepartmentID.ValueMember = "DeptID";

                    // Retrieve course information based on courseID
                    string selectQuery = "SELECT * FROM Course WHERE CourseID = @CourseID;";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@CourseID", courseIDToUpdate);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate form controls with existing course data
                        textBoxCourseID.Text = reader["CourseID"].ToString();
                        textBoxCourseName.Text = reader["CourseName"].ToString();
                        textBoxCreditHour.Text = reader["CreditHour"].ToString();

                        // Select the DepartmentID based on course data
                        string selectedDepartmentID = reader["DepartmentID"].ToString();
                        comboBoxDepartmentID.SelectedValue = selectedDepartmentID;
                    }
                    else
                    {
                        MessageBox.Show("No course found with the specified course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Optionally, close the form or take appropriate action
                        this.Close();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxCourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCreditHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve updated course information from the form
                string newCourseID = textBoxCourseID.Text.Trim();
                string courseName = textBoxCourseName.Text.Trim();

                int creditHour;

                if (!int.TryParse(textBoxCreditHour.Text.Trim(), out creditHour))
                {
                    MessageBox.Show("Please enter a valid Credit Hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newDepartmentID = comboBoxDepartmentID.SelectedValue.ToString();

                if (string.IsNullOrEmpty(newCourseID) || string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(newDepartmentID))
                {
                    MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                    // Check if the new course ID and department ID combination already exists
                    if (!IsCourseIDDepartmentIDUnique(newCourseID, newDepartmentID))
                    {
                        MessageBox.Show("The combination of Course ID and Department ID already exists. Please choose a different Course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Execute the update query for the Course table
                        string updateCourseQuery = "UPDATE Course " +
                                                   "SET CourseID=@NewCourseID, CourseName=@CourseName, CreditHour=@CreditHour, DepartmentID=@NewDepartmentID " +
                                                   "WHERE CourseID = @CourseID OR DepartmentID= @DepartmentID ;";

                        SqlCommand updateCourseCommand = new SqlCommand(updateCourseQuery, connection);
                        updateCourseCommand.Parameters.AddWithValue("@CourseID", courseIDToUpdate);
                        updateCourseCommand.Parameters.AddWithValue("@NewCourseID", newCourseID);
                        updateCourseCommand.Parameters.AddWithValue("@CourseName", courseName);
                        updateCourseCommand.Parameters.AddWithValue("@CreditHour", creditHour);
                        updateCourseCommand.Parameters.AddWithValue("@DepartmentID", departmentIDToUpdate);
                        updateCourseCommand.Parameters.AddWithValue("@NewDepartmentID", newDepartmentID);

                        // Execute the update query for the Course table
                        int rowsAffectedCourse = updateCourseCommand.ExecuteNonQuery();

                        if (rowsAffectedCourse > 0)
                        {
                            MessageBox.Show("Course information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after displaying the success message
                        }
                        else
                        {
                            MessageBox.Show("No course found with the specified course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute the delete query for the Course table
                    string deleteCourseQuery = "DELETE FROM Course WHERE CourseID = @CourseID;";

                    SqlCommand deleteCourseCommand = new SqlCommand(deleteCourseQuery, connection);
                    deleteCourseCommand.Parameters.AddWithValue("@CourseID", courseIDToUpdate);

                    // Execute the delete query for the Course table
                    int rowsAffectedCourse = deleteCourseCommand.ExecuteNonQuery();

                    if (rowsAffectedCourse > 0)
                    {
                        MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the form after displaying the success message
                    }
                    else
                    {
                        MessageBox.Show("No course found with the specified course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void UpdateDeleteCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
