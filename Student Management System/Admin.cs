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
    public partial class Admin : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private string adminUsername;
        public Admin(string adminUsername)
        {
            InitializeComponent();
            this.adminUsername = adminUsername;
            LoadAdminInformation();
        }
        private void LoadAdminInformation()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FullName, UserName, ProfileImage FROM Admins WHERE UserName = @AdminUsername";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.Add("@AdminUsername", SqlDbType.NVarChar, 50).Value = adminUsername;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["FullName"].ToString();
                            string userType = "Administrator";

                            labelFullAdminName.Text = fullName.ToUpper();
                            labelAdminUserNmae.Text = adminUsername;
                            labelUserType.Text = userType;

                            if (reader["ProfileImage"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["ProfileImage"];

                                // Debugging: Output the length of the image data
                                Console.WriteLine("Image Data Length: " + imageData.Length);

                                // Debugging: Output the first few bytes of the image data
                                Console.WriteLine("First Bytes: " + BitConverter.ToString(imageData.Take(10).ToArray()));

                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBoxAdminImage.Image = Image.FromStream(ms);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Debugging: Output any exception details
                                    Console.WriteLine("Exception: " + ex.Message);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFullAdminName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelUserType_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdminImage_Click(object sender, EventArgs e)
        {

        }

        private void labelAdminUserNmae_Click(object sender, EventArgs e)
        {

        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updaetAdminProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EditMyProfileAdminForm editForm = new EditMyProfileAdminForm(adminUsername);

            // Show the form as a dialog (modal)
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload admin information after the update if needed
                LoadAdminInformation();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.Show();

        }

        private void updateDeleteDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void departmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the DepartmentListForm when "Department List" menu item is clicked
            DepartmentListForm departmentListForm = new DepartmentListForm();
            departmentListForm.Show();
        }

        private void courseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Add Course form
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void updateDeleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Course List form
            CourseListForm courseListForm = new CourseListForm();
            courseListForm.ShowDialog();
        }

        private void teacherManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInstructorForm addInstructorForm = new AddInstructorForm();

            // Show the AddInstructorForm
            addInstructorForm.ShowDialog();
        }

        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addNewStudentForm = new AddNewStudentForm();
            addNewStudentForm.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
