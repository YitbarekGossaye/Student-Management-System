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

    public partial class AddDepartmentForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepartmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve department information from the text boxes
                string departmentID = textBoxDepartmentID.Text.Trim();
                string departmentName = textBoxDepartmentName.Text.Trim();

                // Validate input (ensure required fields are not empty)
                if (string.IsNullOrEmpty(departmentID) || string.IsNullOrEmpty(departmentName))
                {
                    MessageBox.Show("Please enter both Department ID and Department Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string checkQuery = "SELECT COUNT(*) FROM Departments WHERE DeptID = @DeptID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@DeptID", departmentID);
                        int departmentCount = (int)checkCommand.ExecuteScalar();

                        if (departmentCount > 0)
                        {
                            MessageBox.Show("Department with the same ID already exists. Please choose a different Department ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Create a dataset and table adapter
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments", connection);

                    // Fill the dataset with existing department data
                    adapter.Fill(ds, "Departments");

                    // Create a new row in the dataset table
                    DataRow newRow = ds.Tables["Departments"].NewRow();
                    newRow["DeptID"] = departmentID;
                    newRow["DepartmentName"] = departmentName;
                    ds.Tables["Departments"].Rows.Add(newRow);

                    // Create a command builder to generate update commands
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    adapter.Update(ds, "Departments");

                    MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text boxes for the next entry
                    textBoxDepartmentID.Text = "";
                    textBoxDepartmentName.Text = "";

                    // Set DialogResult to OK to indicate successful addition
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelDepartmentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
