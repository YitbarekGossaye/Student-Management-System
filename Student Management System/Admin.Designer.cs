
namespace Student_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updaetAdminProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelAdminUserNmae = new System.Windows.Forms.Label();
            this.labelFullAdminName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxAdminImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-4, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 606);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(67, 551);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(142, 43);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.teacherManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem,
            this.departmentManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 606);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.AutoSize = false;
            this.myAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updaetAdminProfileToolStripMenuItem});
            this.myAccountToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.myAccountToolStripMenuItem.Text = "My Account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // updaetAdminProfileToolStripMenuItem
            // 
            this.updaetAdminProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.updaetAdminProfileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updaetAdminProfileToolStripMenuItem.Name = "updaetAdminProfileToolStripMenuItem";
            this.updaetAdminProfileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 1, 0, 10);
            this.updaetAdminProfileToolStripMenuItem.Size = new System.Drawing.Size(182, 31);
            this.updaetAdminProfileToolStripMenuItem.Text = "Update Profile";
            this.updaetAdminProfileToolStripMenuItem.Click += new System.EventHandler(this.updaetAdminProfileToolStripMenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.AutoSize = false;
            this.studentManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            this.studentManagementToolStripMenuItem.Click += new System.EventHandler(this.studentManagementToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentListToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // teacherManagementToolStripMenuItem
            // 
            this.teacherManagementToolStripMenuItem.AutoSize = false;
            this.teacherManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.teacherManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTeacherToolStripMenuItem});
            this.teacherManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.teacherManagementToolStripMenuItem.Name = "teacherManagementToolStripMenuItem";
            this.teacherManagementToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.teacherManagementToolStripMenuItem.Text = "Instructor  Management";
            this.teacherManagementToolStripMenuItem.Click += new System.EventHandler(this.teacherManagementToolStripMenuItem_Click);
            // 
            // addNewTeacherToolStripMenuItem
            // 
            this.addNewTeacherToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addNewTeacherToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTeacherToolStripMenuItem.Name = "addNewTeacherToolStripMenuItem";
            this.addNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addNewTeacherToolStripMenuItem.Text = "Add New Instructor";
            this.addNewTeacherToolStripMenuItem.Click += new System.EventHandler(this.addNewTeacherToolStripMenuItem_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.AutoSize = false;
            this.courseManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.courseListToolStripMenuItem});
            this.courseManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            this.courseManagementToolStripMenuItem.Click += new System.EventHandler(this.courseManagementToolStripMenuItem_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addCourseToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course ";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // courseListToolStripMenuItem
            // 
            this.courseListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.courseListToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            this.courseListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.courseListToolStripMenuItem.Text = "Course List";
            this.courseListToolStripMenuItem.Click += new System.EventHandler(this.courseListToolStripMenuItem_Click);
            // 
            // departmentManagementToolStripMenuItem
            // 
            this.departmentManagementToolStripMenuItem.AutoSize = false;
            this.departmentManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.departmentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem});
            this.departmentManagementToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.departmentManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.departmentManagementToolStripMenuItem.Name = "departmentManagementToolStripMenuItem";
            this.departmentManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.departmentManagementToolStripMenuItem.Text = "Department Management";
            this.departmentManagementToolStripMenuItem.Click += new System.EventHandler(this.departmentManagementToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addDepartmentToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 753);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1096, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Pink;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(157, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(956, 430);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Profile";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelUserType);
            this.groupBox1.Controls.Add(this.labelAdminUserNmae);
            this.groupBox1.Controls.Add(this.labelFullAdminName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBoxAdminImage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelUserType
            // 
            this.labelUserType.Location = new System.Drawing.Point(145, 205);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(317, 29);
            this.labelUserType.TabIndex = 8;
            this.labelUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserType.Click += new System.EventHandler(this.labelUserType_Click);
            // 
            // labelAdminUserNmae
            // 
            this.labelAdminUserNmae.BackColor = System.Drawing.Color.White;
            this.labelAdminUserNmae.Location = new System.Drawing.Point(145, 131);
            this.labelAdminUserNmae.Name = "labelAdminUserNmae";
            this.labelAdminUserNmae.Size = new System.Drawing.Size(317, 29);
            this.labelAdminUserNmae.TabIndex = 7;
            this.labelAdminUserNmae.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAdminUserNmae.Click += new System.EventHandler(this.labelAdminUserNmae_Click);
            // 
            // labelFullAdminName
            // 
            this.labelFullAdminName.Location = new System.Drawing.Point(145, 69);
            this.labelFullAdminName.Name = "labelFullAdminName";
            this.labelFullAdminName.Size = new System.Drawing.Size(317, 29);
            this.labelFullAdminName.TabIndex = 6;
            this.labelFullAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFullAdminName.Click += new System.EventHandler(this.labelFullAdminName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username :";
            // 
            // pictureBoxAdminImage
            // 
            this.pictureBoxAdminImage.Location = new System.Drawing.Point(573, 26);
            this.pictureBoxAdminImage.Name = "pictureBoxAdminImage";
            this.pictureBoxAdminImage.Size = new System.Drawing.Size(349, 260);
            this.pictureBoxAdminImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdminImage.TabIndex = 4;
            this.pictureBoxAdminImage.TabStop = false;
            this.pictureBoxAdminImage.Click += new System.EventHandler(this.pictureBoxAdminImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 150);
            this.panel3.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updaetAdminProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseListToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAdminUserNmae;
        private System.Windows.Forms.Label labelFullAdminName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAdminImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.ToolStripMenuItem departmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button buttonLogout;
    }
}