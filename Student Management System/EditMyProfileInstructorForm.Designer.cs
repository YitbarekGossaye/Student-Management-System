
namespace Student_Management_System
{
    partial class EditMyProfileInstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMyProfileInstructorForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.UploadInstructorImageBtn = new System.Windows.Forms.Button();
            this.pictureBoxInstructorImage = new System.Windows.Forms.PictureBox();
            this.textBoxInstructorEmail = new System.Windows.Forms.TextBox();
            this.textBoxInstructorPassword = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstructorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(340, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 690);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(40, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 62);
            this.panel5.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(275, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "EDIT PROFILE INFORMATION FORM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelSex);
            this.groupBox1.Controls.Add(this.labelFullName);
            this.groupBox1.Controls.Add(this.labelUserName);
            this.groupBox1.Controls.Add(this.labelDepartment);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.UploadInstructorImageBtn);
            this.groupBox1.Controls.Add(this.pictureBoxInstructorImage);
            this.groupBox1.Controls.Add(this.textBoxInstructorEmail);
            this.groupBox1.Controls.Add(this.textBoxInstructorPassword);
            this.groupBox1.Controls.Add(this.dateTimePickerDOB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 557);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // labelSex
            // 
            this.labelSex.Location = new System.Drawing.Point(129, 108);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(285, 27);
            this.labelSex.TabIndex = 31;
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSex.Click += new System.EventHandler(this.labelSex_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.Location = new System.Drawing.Point(121, 34);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(285, 27);
            this.labelFullName.TabIndex = 30;
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFullName.Click += new System.EventHandler(this.labelFullName_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Location = new System.Drawing.Point(125, 282);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(285, 27);
            this.labelUserName.TabIndex = 29;
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.Location = new System.Drawing.Point(125, 222);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(285, 27);
            this.labelDepartment.TabIndex = 26;
            this.labelDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDepartment.Click += new System.EventHandler(this.labelDepartment_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.LightGreen;
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Location = new System.Drawing.Point(454, 496);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(165, 41);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(665, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Profile Image";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadInstructorImageBtn
            // 
            this.UploadInstructorImageBtn.BackColor = System.Drawing.Color.LightGreen;
            this.UploadInstructorImageBtn.ForeColor = System.Drawing.Color.Black;
            this.UploadInstructorImageBtn.Location = new System.Drawing.Point(675, 365);
            this.UploadInstructorImageBtn.Name = "UploadInstructorImageBtn";
            this.UploadInstructorImageBtn.Size = new System.Drawing.Size(248, 37);
            this.UploadInstructorImageBtn.TabIndex = 22;
            this.UploadInstructorImageBtn.Text = "Upload Image";
            this.UploadInstructorImageBtn.UseVisualStyleBackColor = false;
            this.UploadInstructorImageBtn.Click += new System.EventHandler(this.UploadInstructorImageBtn_Click);
            // 
            // pictureBoxInstructorImage
            // 
            this.pictureBoxInstructorImage.Location = new System.Drawing.Point(669, 79);
            this.pictureBoxInstructorImage.Name = "pictureBoxInstructorImage";
            this.pictureBoxInstructorImage.Size = new System.Drawing.Size(254, 255);
            this.pictureBoxInstructorImage.TabIndex = 21;
            this.pictureBoxInstructorImage.TabStop = false;
            this.pictureBoxInstructorImage.Click += new System.EventHandler(this.pictureBoxInstructorImage_Click);
            // 
            // textBoxInstructorEmail
            // 
            this.textBoxInstructorEmail.Location = new System.Drawing.Point(129, 389);
            this.textBoxInstructorEmail.MaxLength = 10;
            this.textBoxInstructorEmail.Name = "textBoxInstructorEmail";
            this.textBoxInstructorEmail.Size = new System.Drawing.Size(285, 27);
            this.textBoxInstructorEmail.TabIndex = 19;
            this.textBoxInstructorEmail.TextChanged += new System.EventHandler(this.textBoxInstructorEmail_TextChanged);
            // 
            // textBoxInstructorPassword
            // 
            this.textBoxInstructorPassword.Location = new System.Drawing.Point(125, 332);
            this.textBoxInstructorPassword.MaxLength = 4;
            this.textBoxInstructorPassword.Name = "textBoxInstructorPassword";
            this.textBoxInstructorPassword.Size = new System.Drawing.Size(285, 27);
            this.textBoxInstructorPassword.TabIndex = 8;
            this.textBoxInstructorPassword.TextChanged += new System.EventHandler(this.textBoxInstructorPassword_TextChanged);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.AllowDrop = true;
            this.dateTimePickerDOB.CalendarTitleForeColor = System.Drawing.Color.Moccasin;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(125, 162);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(285, 27);
            this.dateTimePickerDOB.TabIndex = 15;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "UserName :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "DOB :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 138);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 613);
            this.panel1.TabIndex = 13;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1361, -3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // EditMyProfileInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditMyProfileInstructorForm";
            this.Text = "EditMyProfileInstructorForm";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstructorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UploadInstructorImageBtn;
        private System.Windows.Forms.PictureBox pictureBoxInstructorImage;
        private System.Windows.Forms.TextBox textBoxInstructorEmail;
        private System.Windows.Forms.TextBox textBoxInstructorPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Button closeBtn;
    }
}