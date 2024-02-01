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

namespace Student_Management_System
{
   
    public partial class InstructorForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private string InstructorUsername;
        public InstructorForm(string InstructorUsername)
        {
            InitializeComponent();
            this.InstructorUsername = InstructorUsername;
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SQL query to retrieve the necessary information from the instructors table
                    string query = "SELECT FirstName, LastName, DeptID FROM Instructors WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", InstructorUsername);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        // Access the necessary information from the DataTable and assign it to the respective labels
                        string firstName = row["FirstName"].ToString();
                        string lastName = row["LastName"].ToString();
                        string deptID = row["DeptID"].ToString();

                        labelFullInstructorName.Text = firstName + " " + lastName;
                        labelInstructorUserName.Text = InstructorUsername;
                        labelInstructorDepartmentName.Text = deptID;
                    }
                    else
                    {
                        // Handle the case when no instructor is found with the given username
                        MessageBox.Show("Instructor not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void labelFullInstructorName_Click(object sender, EventArgs e)
        {

        }

        private void labelInstructorUserName_Click(object sender, EventArgs e)
        {

        }

        private void labelInstructorDepartmentName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInstructormage_Click(object sender, EventArgs e)
        {

        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
