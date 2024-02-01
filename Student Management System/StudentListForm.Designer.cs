
namespace Student_Management_System
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalFemaleStudent = new System.Windows.Forms.Label();
            this.labelTotalMaleStudent = new System.Windows.Forms.Label();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.UpdateSelectedStudentBtn = new System.Windows.Forms.Button();
            this.DeleteSelectedStudentBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(371, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 63);
            this.panel3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(216, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "STUDENT LIST ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 129);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 609);
            this.panel1.TabIndex = 12;
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
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(371, 162);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(1000, 400);
            this.dataGridViewStudentList.TabIndex = 13;
            this.dataGridViewStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellContentClick);
            this.dataGridViewStudentList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Students :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Male :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelTotalFemaleStudent);
            this.groupBox1.Controls.Add(this.labelTotalMaleStudent);
            this.groupBox1.Controls.Add(this.labelTotalStudent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(538, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalFemaleStudent
            // 
            this.labelTotalFemaleStudent.Location = new System.Drawing.Point(584, 23);
            this.labelTotalFemaleStudent.Name = "labelTotalFemaleStudent";
            this.labelTotalFemaleStudent.Size = new System.Drawing.Size(70, 19);
            this.labelTotalFemaleStudent.TabIndex = 19;
            this.labelTotalFemaleStudent.Click += new System.EventHandler(this.labelTotalFemaleStudent_Click);
            // 
            // labelTotalMaleStudent
            // 
            this.labelTotalMaleStudent.Location = new System.Drawing.Point(366, 23);
            this.labelTotalMaleStudent.Name = "labelTotalMaleStudent";
            this.labelTotalMaleStudent.Size = new System.Drawing.Size(70, 19);
            this.labelTotalMaleStudent.TabIndex = 18;
            this.labelTotalMaleStudent.Click += new System.EventHandler(this.labelTotalMaleStudent_Click);
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.Location = new System.Drawing.Point(147, 23);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(70, 19);
            this.labelTotalStudent.TabIndex = 17;
            this.labelTotalStudent.Click += new System.EventHandler(this.labelTotalStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Female :";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.AddStudentBtn.FlatAppearance.BorderSize = 0;
            this.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.AddStudentBtn.Location = new System.Drawing.Point(1144, 650);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(165, 41);
            this.AddStudentBtn.TabIndex = 30;
            this.AddStudentBtn.Text = "Add";
            this.AddStudentBtn.UseVisualStyleBackColor = false;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // UpdateSelectedStudentBtn
            // 
            this.UpdateSelectedStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpdateSelectedStudentBtn.FlatAppearance.BorderSize = 0;
            this.UpdateSelectedStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSelectedStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateSelectedStudentBtn.Location = new System.Drawing.Point(774, 650);
            this.UpdateSelectedStudentBtn.Name = "UpdateSelectedStudentBtn";
            this.UpdateSelectedStudentBtn.Size = new System.Drawing.Size(165, 41);
            this.UpdateSelectedStudentBtn.TabIndex = 31;
            this.UpdateSelectedStudentBtn.Text = "Update";
            this.UpdateSelectedStudentBtn.UseVisualStyleBackColor = false;
            this.UpdateSelectedStudentBtn.Click += new System.EventHandler(this.UpdateSelectedStudentBtn_Click);
            // 
            // DeleteSelectedStudentBtn
            // 
            this.DeleteSelectedStudentBtn.BackColor = System.Drawing.Color.Coral;
            this.DeleteSelectedStudentBtn.FlatAppearance.BorderSize = 0;
            this.DeleteSelectedStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedStudentBtn.Location = new System.Drawing.Point(388, 650);
            this.DeleteSelectedStudentBtn.Name = "DeleteSelectedStudentBtn";
            this.DeleteSelectedStudentBtn.Size = new System.Drawing.Size(165, 41);
            this.DeleteSelectedStudentBtn.TabIndex = 32;
            this.DeleteSelectedStudentBtn.Text = "Delete";
            this.DeleteSelectedStudentBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedStudentBtn.Click += new System.EventHandler(this.DeleteSelectedStudentBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1370, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.DeleteSelectedStudentBtn);
            this.Controls.Add(this.UpdateSelectedStudentBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalFemaleStudent;
        private System.Windows.Forms.Label labelTotalMaleStudent;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button UpdateSelectedStudentBtn;
        private System.Windows.Forms.Button DeleteSelectedStudentBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}