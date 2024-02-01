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
    public partial class EditMyProfileAdminForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        private string adminUsername;

        public EditMyProfileAdminForm(string adminUsername)
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

                string query = "SELECT FullName, UserName, Password, ProfileImage, Sex, Phone, DOB FROM Admins WHERE UserName = @AdminUsername";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminUsername", adminUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate form fields with retrieved data
                            labelFullAdminName.Text = reader["FullName"].ToString();
                            labelAdminSex.Text = reader["Sex"].ToString();
                            dateTimePickerDOB.Value = Convert.ToDateTime(reader["DOB"]);
                            labelAdminUserNmae.Text = adminUsername;
                            labelUserType.Text = "Adminstrator";
                            textBoxAdminPassword.Text = reader["Password"].ToString();
                            textBoxAdminPhone.Text = reader["Phone"].ToString();

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

        private void labelFullAdminName_Click(object sender, EventArgs e)
        {

        }

        private void labelAdminSex_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelAdminUserNmae_Click(object sender, EventArgs e)
        {

        }

        private void labelUserType_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdminPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdminImage_Click(object sender, EventArgs e)
        {

        }

        private void UploadAdminImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAdminImage.Image = new Bitmap(openFileDialog.FileName);
                }
            }

        }

        private void UpdateAdminBtn_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Admins SET DOB = @DOB, Password = @Password, ProfileImage = @ProfileImage WHERE UserName = @AdminUsername";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@DOB", dateTimePickerDOB.Value);
                    updateCommand.Parameters.AddWithValue("@Password", textBoxAdminPassword.Text);

                    // Convert the Image to a byte array for storage in the database
                    if (pictureBoxAdminImage.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            ImageConverter converter = new ImageConverter();
                            byte[] imageData = (byte[])converter.ConvertTo(pictureBoxAdminImage.Image, typeof(byte[]));
                            updateCommand.Parameters.AddWithValue("@ProfileImage", imageData);
                        }
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@ProfileImage", DBNull.Value);
                    }

                    updateCommand.Parameters.AddWithValue("@AdminUsername", adminUsername);

                    // Execute the update query
                    updateCommand.ExecuteNonQuery();
                    
                }


                // Update Admin Password in Users table
                string updateUserQuery = "UPDATE Users SET Password = @Password WHERE Username = @AdminUsername";
                using (SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, connection))
                {
                    updateUserCommand.Parameters.AddWithValue("@Password", textBoxAdminPassword.Text);
                    updateUserCommand.Parameters.AddWithValue("@AdminUsername", adminUsername);

                    // Execute the update query for Users table
                    updateUserCommand.ExecuteNonQuery();
                }
               MessageBox.Show("Admin information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
