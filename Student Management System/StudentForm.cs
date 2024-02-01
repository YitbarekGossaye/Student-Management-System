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
    public partial class StudentForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private string studentUsername;

        public StudentForm(string studentUsername)
        {
            InitializeComponent();
            this.studentUsername = studentUsername;
            LoadStudentInformation();
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void labelFullStudentName_Click(object sender, EventArgs e)
        {

        }

        private void labelStudentUserNmae_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelYear_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudentmage_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadStudentInformation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming there's a table named Students with columns Username, FirstName, LastName, DepartmentID, Year, etc.
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE Username = @Username", connection))
                    {
                        command.Parameters.AddWithValue("@Username", studentUsername);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                labelFullStudentName.Text =   reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                labeStudentDepartmentId.Text =  reader["DepartmentID"].ToString();
                                labelYear.Text = reader["Year"].ToString();
                                labelStudentUserNmae.Text = reader["Username"].ToString();

                                // You can also load the profile image if it's stored as VARBINARY
                                if (reader["ProfileImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["ProfileImage"];
                                    MemoryStream ms = new MemoryStream(imageData);
                                    pictureBoxStudentmage.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
