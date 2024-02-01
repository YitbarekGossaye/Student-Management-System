
namespace Student_Management_System
{
    partial class AddScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScoreForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelinstructorUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddScoreBtn = new System.Windows.Forms.Button();
            this.UpdateScoreBtn = new System.Windows.Forms.Button();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentUSerName = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 129);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 594);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(337, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 649);
            this.panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelinstructorUserName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.AddScoreBtn);
            this.groupBox1.Controls.Add(this.UpdateScoreBtn);
            this.groupBox1.Controls.Add(this.textBoxScore);
            this.groupBox1.Controls.Add(this.textBoxStudentName);
            this.groupBox1.Controls.Add(this.textBoxStudentUSerName);
            this.groupBox1.Controls.Add(this.textBoxCourseName);
            this.groupBox1.Controls.Add(this.textBoxCourseID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 491);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelinstructorUserName
            // 
            this.labelinstructorUserName.Location = new System.Drawing.Point(196, 23);
            this.labelinstructorUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelinstructorUserName.Name = "labelinstructorUserName";
            this.labelinstructorUserName.Size = new System.Drawing.Size(268, 19);
            this.labelinstructorUserName.TabIndex = 32;
            this.labelinstructorUserName.Click += new System.EventHandler(this.labelinstructorUserName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Instructor UserName :";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(168, 370);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(165, 41);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddScoreBtn
            // 
            this.AddScoreBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AddScoreBtn.ForeColor = System.Drawing.Color.Black;
            this.AddScoreBtn.Location = new System.Drawing.Point(632, 370);
            this.AddScoreBtn.Name = "AddScoreBtn";
            this.AddScoreBtn.Size = new System.Drawing.Size(165, 41);
            this.AddScoreBtn.TabIndex = 29;
            this.AddScoreBtn.Text = "Add";
            this.AddScoreBtn.UseVisualStyleBackColor = false;
            this.AddScoreBtn.Click += new System.EventHandler(this.AddScoreBtn_Click);
            // 
            // UpdateScoreBtn
            // 
            this.UpdateScoreBtn.BackColor = System.Drawing.Color.LightGreen;
            this.UpdateScoreBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateScoreBtn.Location = new System.Drawing.Point(403, 370);
            this.UpdateScoreBtn.Name = "UpdateScoreBtn";
            this.UpdateScoreBtn.Size = new System.Drawing.Size(165, 41);
            this.UpdateScoreBtn.TabIndex = 26;
            this.UpdateScoreBtn.Text = "Update";
            this.UpdateScoreBtn.UseVisualStyleBackColor = false;
            this.UpdateScoreBtn.Click += new System.EventHandler(this.UpdateScoreBtn_Click);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(200, 289);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(264, 27);
            this.textBoxScore.TabIndex = 11;
            this.textBoxScore.TextChanged += new System.EventHandler(this.textBoxScore_TextChanged);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(200, 236);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(264, 27);
            this.textBoxStudentName.TabIndex = 10;
            this.textBoxStudentName.TextChanged += new System.EventHandler(this.textBoxStudentName_TextChanged);
            // 
            // textBoxStudentUSerName
            // 
            this.textBoxStudentUSerName.Location = new System.Drawing.Point(200, 174);
            this.textBoxStudentUSerName.Name = "textBoxStudentUSerName";
            this.textBoxStudentUSerName.Size = new System.Drawing.Size(264, 27);
            this.textBoxStudentUSerName.TabIndex = 9;
            this.textBoxStudentUSerName.TextChanged += new System.EventHandler(this.textBoxStudentUSerName_TextChanged);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(200, 112);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(264, 27);
            this.textBoxCourseName.TabIndex = 8;
            this.textBoxCourseName.TextChanged += new System.EventHandler(this.textBoxCourseName_TextChanged);
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(200, 68);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(264, 27);
            this.textBoxCourseID.TabIndex = 7;
            this.textBoxCourseID.TextChanged += new System.EventHandler(this.textBoxCourseID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student UserName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(19, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(994, 63);
            this.panel4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(216, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "ADD SCORE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentUSerName;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button UpdateScoreBtn;
        private System.Windows.Forms.Button AddScoreBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelinstructorUserName;
    }
}