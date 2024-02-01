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
    public partial class AddInstructorForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";

        public AddInstructorForm()
        {
            InitializeComponent();
            LoadDepartmentIDs();
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
        private void textBoxFirstInstructorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastInstructorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxSex_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonSexMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSexFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInstructorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInstructorUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInstructorPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxInstructorImage_Click(object sender, EventArgs e)
        {

        }

        private void UploadInstructorImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    pictureBoxInstructorImage.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve instructor information from the form
                string firstName = textBoxFirstInstructorName.Text.Trim();
                string lastName = textBoxLastInstructorName.Text.Trim();
                string sex = radioButtonSexMale.Checked ? "Male" : "Female";
                DateTime dateOfBirth = dateTimePickerDOB.Value;
                string departmentID = comboBoxDepartmentID.SelectedValue.ToString();
                string email = textBoxInstructorEmail.Text.Trim();
                string userName = textBoxInstructorUserName.Text.Trim();
                string password = textBoxInstructorPassword.Text.Trim();

                // Validate input (ensure required fields are not empty)
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(departmentID) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsEmailValid(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsUsernameExists(userName))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                byte[] imageData = null;

                // Check if an image is selected
                if (pictureBoxInstructorImage.Image != null)
                {
                    // Convert the image to byte array
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxInstructorImage.Image.Save(ms, pictureBoxInstructorImage.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert new instructor into the Instructors table
                    string insertInstructorQuery = "INSERT INTO Instructors (Username, FirstName, LastName, Sex, DateOfBirth, DeptID, Email, Password, ProfileImage) " +
                                                   "VALUES (@Username, @FirstName, @LastName, @Sex, @DateOfBirth, @DeptID, @Email, @Password, @Image); SELECT SCOPE_IDENTITY();";

                    SqlCommand insertInstructorCommand = new SqlCommand(insertInstructorQuery, connection);
                    insertInstructorCommand.Parameters.AddWithValue("@Username", userName);
                    insertInstructorCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertInstructorCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertInstructorCommand.Parameters.AddWithValue("@Sex", sex);
                    insertInstructorCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    insertInstructorCommand.Parameters.AddWithValue("@DeptID", departmentID);
                    insertInstructorCommand.Parameters.AddWithValue("@Email", email);
                    insertInstructorCommand.Parameters.AddWithValue("@Password", password);
                    insertInstructorCommand.Parameters.AddWithValue("@Image", imageData);

                    // Get the newly inserted instructor's ID
                   

                    // Insert username and password into the User table
                    string insertUserQuery = "INSERT INTO Users (Username, Password, UserType) VALUES (@Username, @Password, @UserType)";
                    SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@Username", userName);
                    insertUserCommand.Parameters.AddWithValue("@Password", password);
                    insertUserCommand.Parameters.AddWithValue("@UserType", "Instructor");
                    

                    // Execute the insert queries
                    insertUserCommand.ExecuteNonQuery();

                    MessageBox.Show("Instructor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form for the next entry
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding instructor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {
            textBoxFirstInstructorName.Text = "";
            textBoxLastInstructorName.Text = "";
            radioButtonSexMale.Checked = true;
            dateTimePickerDOB.Value = DateTime.Now;
            comboBoxDepartmentID.SelectedIndex = -1;
            textBoxInstructorEmail.Text = "";
            textBoxInstructorUserName.Text = "";
            textBoxInstructorPassword.Text = "";
        }
        private bool IsEmailValid(string email)
        {
            // Regular expression for a simple email validation
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
        private bool IsUsernameExists(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();

                    // If count is greater than 0, the username already exists
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
