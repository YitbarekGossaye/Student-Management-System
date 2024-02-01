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

namespace Student_Management_System
{
    public partial class Login : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
           
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void showPasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = showPasswordcheckBox.Checked ? '\0' : '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUserId.Text;
            string password = textBoxPassword.Text;

            // Check user credentials
            if (AuthenticateUser(username, password, out string userType))
            {
                OpenRespectiveForm(userType, username);
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool AuthenticateUser(string username, string password, out string userType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserType FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userType = result.ToString();
                        return true;
                    }
                    else
                    {
                        userType = null;
                        return false;
                    }
                }
            }
        }

        private void OpenRespectiveForm(string userType, string username)
        {
            switch (userType)
            {
                case "Admin":
                    Admin adminForm = new Admin(username);
                    adminForm.Show();
                    break;

                case "Student":
                    StudentForm studentForm = new StudentForm(username);
                    studentForm.Show();
                    break;

                case "Instructor":
                    InstructorForm instructorForm = new InstructorForm(username);
                    instructorForm.Show();
                    break;

                default:
                    MessageBox.Show("Unknown user type.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
      
        private void textBoxUserId_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserId_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
           
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBoxUserId.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
