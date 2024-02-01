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
    public partial class AddNewStudentForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        public AddNewStudentForm()
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

                    string query = "SELECT DeptID FROM Departments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Departments");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGenderMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGenderFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOBStudent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudentEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudentUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudentImage_Click(object sender, EventArgs e)
        {

        }

        private void UploadStudentImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStudentImage.Image = new Bitmap(openFileDialog.FileName);
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
                // Retrieve student information from the form
                string firstName = textBoxFirstStudentName.Text.Trim();
                string lastName = textBoxLastStudentName.Text.Trim();
                string gender = radioButtonGenderMale.Checked ? "Male" : "Female";
                DateTime dateOfBirth = dateTimePickerDOBStudent.Value;
                string departmentID = comboBoxDepartmentID.SelectedValue.ToString();
                string email = textBoxStudentEmail.Text.Trim();
                string userName = textBoxStudentUserName.Text.Trim();
                string password = textBoxStudentPassword.Text.Trim();
                int year = Convert.ToInt32(textBoxYear.Text.Trim());
               
                if (int.TryParse(textBoxYear.Text.Trim(), out int parsedYear))
                {
                    year = parsedYear;
                }


                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(departmentID) ||
                     string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || year == 0)
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
                if (pictureBoxStudentImage.Image != null)
                {
                    // Convert the image to byte array
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxStudentImage.Image.Save(ms, pictureBoxStudentImage.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert new student into the Students table
                    string insertStudentQuery = "INSERT INTO Students (Username, FirstName, LastName, Sex, DateOfBirth, DepartmentID, Year, Email, Password, ProfileImage) " +
                                                "VALUES (@Username, @FirstName, @LastName, @Sex, @DateOfBirth, @DepartmentID, @Year, @Email, @Password, @Image);";

                    SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
                    insertStudentCommand.Parameters.AddWithValue("@Username", userName);
                    insertStudentCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertStudentCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertStudentCommand.Parameters.AddWithValue("@Sex", gender);
                    insertStudentCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    insertStudentCommand.Parameters.AddWithValue("@DepartmentID", departmentID);
                    insertStudentCommand.Parameters.AddWithValue("@Year", year);
                    insertStudentCommand.Parameters.AddWithValue("@Email", email);
                    insertStudentCommand.Parameters.AddWithValue("@Password", password);
                    insertStudentCommand.Parameters.AddWithValue("@Image", imageData);

                    // Insert username and password into the User table
                    string insertUserQuery = "INSERT INTO Users (Username, Password, UserType) VALUES (@Username, @Password, @UserType)";
                    SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@Username", userName);
                    insertUserCommand.Parameters.AddWithValue("@Password", password);
                    insertUserCommand.Parameters.AddWithValue("@UserType", "Student");

                    // Execute the insert queries
                    insertStudentCommand.ExecuteNonQuery();
                    insertUserCommand.ExecuteNonQuery();

                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form for the next entry
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
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

        private void ClearForm()
        {
            textBoxFirstStudentName.Text = "";
            textBoxLastStudentName.Text = "";
            radioButtonGenderMale.Checked = true;
            dateTimePickerDOBStudent.Value = DateTime.Now;
            comboBoxDepartmentID.SelectedIndex = -1;
            textBoxStudentEmail.Text = "";
            textBoxStudentUserName.Text = "";
            textBoxStudentPassword.Text = "";
            textBoxYear.Text = "";
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
