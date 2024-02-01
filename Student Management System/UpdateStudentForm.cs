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
    public partial class UpdateStudentForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private readonly string usernameToUpdate;

        public UpdateStudentForm(string username)
        {
            InitializeComponent();
            usernameToUpdate = username;
            LoadStudentInformation();
        }
        private void LoadStudentInformation()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Retrieve all DepartmentIDs from Departments
                    DataTable departmentsTable = new DataTable();
                    string departmentsQuery = "SELECT DeptID FROM Departments;";
                    using (SqlCommand departmentsCommand = new SqlCommand(departmentsQuery, connection))
                    {
                        using (SqlDataAdapter departmentsAdapter = new SqlDataAdapter(departmentsCommand))
                        {
                            departmentsAdapter.Fill(departmentsTable);
                        }
                    }

                    // Bind the DepartmentIDs to the ComboBox
                    comboBoxDepartmentID.DisplayMember = "DeptID";
                    comboBoxDepartmentID.ValueMember = "DeptID";
                    comboBoxDepartmentID.DataSource = departmentsTable;

                    string selectQuery = "SELECT * FROM Students WHERE Username = @Username;";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@Username", usernameToUpdate);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate form controls with existing student data
                        textBoxFirstStudentName.Text = reader["FirstName"].ToString();
                        textBoxLastStudentName.Text = reader["LastName"].ToString();

                        // Example: Set the radio button based on the gender
                        string gender = reader["Sex"].ToString();
                        if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                        {
                            radioButtonGenderMale.Checked = true;
                        }
                        else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                        {
                            radioButtonGenderFemale.Checked = true;
                        }

                        // Populate DateTimePicker with date of birth
                        dateTimePickerDOBStudent.Value = (DateTime)reader["DateOfBirth"];

                        // Select the DepartmentID based on student data
                        string selectedDepartmentID = reader["DepartmentID"].ToString();
                        comboBoxDepartmentID.SelectedValue = selectedDepartmentID;


                        // Populate other form controls with the remaining fields
                        textBoxYear.Text = reader["Year"].ToString();
                        textBoxStudentEmail.Text = reader["Email"].ToString();
                        textBoxStudentUserName.Text = reader["Username"].ToString();
                        textBoxStudentPassword.Text = reader["Password"].ToString();

                        // Example: Load and display student image
                        byte[] imageData = reader["ProfileImage"] as byte[];
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxStudentImage.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No student found with the specified username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Optionally, close the form or take appropriate action
                        this.Close();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void textBoxYear_TextChanged(object sender, EventArgs e)
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve updated student information from the form
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

                byte[] imageData = null;

                // Check if a new image is selected
                if (pictureBoxStudentImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxStudentImage.Image.Save(ms, pictureBoxStudentImage.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }
                if (IsUsernameExists(userName))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Execute the update query for the Students table
                        string updateStudentQuery = "UPDATE Students " +
                                                     "SET Username=@Username, FirstName = @FirstName, LastName = @LastName, Sex = @Sex, " +
                                                     "DateOfBirth = @DateOfBirth, DepartmentID = @DepartmentID, Year = @Year, " +
                                                     "Email = @Email, Password = @Password, ProfileImage = @ProfileImage " +
                                                     "WHERE Username = @OriginalUsername;";

                        SqlCommand updateStudentCommand = new SqlCommand(updateStudentQuery, connection);
                        updateStudentCommand.Parameters.AddWithValue("@OriginalUsername", usernameToUpdate);
                        updateStudentCommand.Parameters.AddWithValue("@Username", userName);
                        updateStudentCommand.Parameters.AddWithValue("@FirstName", firstName);
                        updateStudentCommand.Parameters.AddWithValue("@LastName", lastName);
                        updateStudentCommand.Parameters.AddWithValue("@Sex", gender);
                        updateStudentCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        updateStudentCommand.Parameters.AddWithValue("@DepartmentID", departmentID);
                        updateStudentCommand.Parameters.AddWithValue("@Year", year);
                        updateStudentCommand.Parameters.AddWithValue("@Email", email);
                        updateStudentCommand.Parameters.AddWithValue("@Password", password);
                        updateStudentCommand.Parameters.AddWithValue("@ProfileImage", imageData);

                        // Execute the update query for the Students table
                        int rowsAffectedStudent = updateStudentCommand.ExecuteNonQuery();
                        string updateUserQuery = "UPDATE Users " +
                         "SET Username = @NewUsername, Password = @Password " +
                         "WHERE Username = @Username;";

                        SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, connection);
                        updateUserCommand.Parameters.AddWithValue("@Username", usernameToUpdate); // Use the original username here // Old username
                        updateUserCommand.Parameters.AddWithValue("@NewUsername", userName);        // New username
                        updateUserCommand.Parameters.AddWithValue("@Password", password);

                        // Execute the update query for the Users table
                        int rowsAffectedUser = updateUserCommand.ExecuteNonQuery();
                        if (rowsAffectedStudent > 0)
                        {
                            MessageBox.Show("Student information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after displaying the success message
                        }
                        else
                        {
                            MessageBox.Show("No student found with the specified username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsUsernameExists( string username)
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
