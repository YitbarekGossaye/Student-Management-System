
namespace Student_Management_System
{
    partial class DepartmentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddDepartmentBtn = new System.Windows.Forms.Button();
            this.UpdateSelectedDepartmentBtn = new System.Windows.Forms.Button();
            this.DeleteSelectedDepartmentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalDepartments = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewDepartmentList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddDepartmentBtn);
            this.panel1.Controls.Add(this.UpdateSelectedDepartmentBtn);
            this.panel1.Controls.Add(this.DeleteSelectedDepartmentBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridViewDepartmentList);
            this.panel1.Location = new System.Drawing.Point(326, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 602);
            this.panel1.TabIndex = 0;
            // 
            // AddDepartmentBtn
            // 
            this.AddDepartmentBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AddDepartmentBtn.ForeColor = System.Drawing.Color.Black;
            this.AddDepartmentBtn.Location = new System.Drawing.Point(789, 551);
            this.AddDepartmentBtn.Name = "AddDepartmentBtn";
            this.AddDepartmentBtn.Size = new System.Drawing.Size(165, 41);
            this.AddDepartmentBtn.TabIndex = 29;
            this.AddDepartmentBtn.Text = "Add";
            this.AddDepartmentBtn.UseVisualStyleBackColor = false;
            this.AddDepartmentBtn.Click += new System.EventHandler(this.AddDepartmentBtn_Click);
            // 
            // UpdateSelectedDepartmentBtn
            // 
            this.UpdateSelectedDepartmentBtn.BackColor = System.Drawing.Color.LightGreen;
            this.UpdateSelectedDepartmentBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateSelectedDepartmentBtn.Location = new System.Drawing.Point(422, 558);
            this.UpdateSelectedDepartmentBtn.Name = "UpdateSelectedDepartmentBtn";
            this.UpdateSelectedDepartmentBtn.Size = new System.Drawing.Size(165, 41);
            this.UpdateSelectedDepartmentBtn.TabIndex = 27;
            this.UpdateSelectedDepartmentBtn.Text = "Update";
            this.UpdateSelectedDepartmentBtn.UseVisualStyleBackColor = false;
            this.UpdateSelectedDepartmentBtn.Click += new System.EventHandler(this.UpdateSelectedDepartmentBtn_Click);
            // 
            // DeleteSelectedDepartmentBtn
            // 
            this.DeleteSelectedDepartmentBtn.BackColor = System.Drawing.Color.Tomato;
            this.DeleteSelectedDepartmentBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedDepartmentBtn.Location = new System.Drawing.Point(46, 558);
            this.DeleteSelectedDepartmentBtn.Name = "DeleteSelectedDepartmentBtn";
            this.DeleteSelectedDepartmentBtn.Size = new System.Drawing.Size(165, 41);
            this.DeleteSelectedDepartmentBtn.TabIndex = 26;
            this.DeleteSelectedDepartmentBtn.Text = "Delete";
            this.DeleteSelectedDepartmentBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedDepartmentBtn.Click += new System.EventHandler(this.DeleteSelectedDepartmentBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelTotalDepartments);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(311, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 61);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalDepartments
            // 
            this.labelTotalDepartments.Location = new System.Drawing.Point(197, 23);
            this.labelTotalDepartments.Name = "labelTotalDepartments";
            this.labelTotalDepartments.Size = new System.Drawing.Size(70, 19);
            this.labelTotalDepartments.TabIndex = 17;
            this.labelTotalDepartments.Click += new System.EventHandler(this.labelTotalDepartments_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Depatrment :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(46, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 63);
            this.panel3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(216, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "DEPARTMENT LIST ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDepartmentList
            // 
            this.dataGridViewDepartmentList.AllowUserToAddRows = false;
            this.dataGridViewDepartmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDepartmentList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentList.Location = new System.Drawing.Point(49, 61);
            this.dataGridViewDepartmentList.Name = "dataGridViewDepartmentList";
            this.dataGridViewDepartmentList.Size = new System.Drawing.Size(933, 406);
            this.dataGridViewDepartmentList.TabIndex = 15;
            this.dataGridViewDepartmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmentList_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 572);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(237, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW STUDENT REGISTRATION FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 147);
            this.panel4.TabIndex = 7;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1366, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DepartmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentListForm";
            this.Load += new System.EventHandler(this.DepartmentListForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDepartmentList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalDepartments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button DeleteSelectedDepartmentBtn;
        private System.Windows.Forms.Button UpdateSelectedDepartmentBtn;
        private System.Windows.Forms.Button AddDepartmentBtn;
    }
}