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
    public partial class DepartmentListForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";
        public DepartmentListForm()
        {
            InitializeComponent();
           
        }

        private void DepartmentListForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            DisplayTotalDepartments();
        }
        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Departments");

                    dataGridViewDepartmentList.DataSource = ds.Tables["Departments"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayTotalDepartments()
        {
            int totalDepartments = dataGridViewDepartmentList.Rows.Count;
            labelTotalDepartments.Text = $"{totalDepartments}";
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotalDepartments_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedDepartmentBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateSelectedDepartmentBtn_Click(object sender, EventArgs e)
        {
           
        }

        // Helper method to check if a DeptID already exists in the database
        private bool IsDeptIDAlreadyExists(SqlConnection connection, string deptID)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Departments WHERE DeptID = @DeptID", connection))
            {
                command.Parameters.AddWithValue("@DeptID", deptID);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addForm = new AddDepartmentForm();
            addForm.ShowDialog();
            LoadDepartments();
            DisplayTotalDepartments();

        }
    }
}
