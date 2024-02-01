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
    public partial class UpdateDeleteDepartmentForm : Form
    {
        private string connectionString = @"Data Source=BIRUK\SQLEXPRESS;Initial Catalog=StudentRecordManagementDB;Integrated Security=True";

        public UpdateDeleteDepartmentForm()
        {
            InitializeComponent();
        }

        private void UpdateDeleteDepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearchingDepartmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchDepartmentIDBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxFDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepartmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void ClearTextBoxes()
        {
           
            // Clear other textboxes as needed
        }
    }
}
