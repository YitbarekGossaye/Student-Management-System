﻿
namespace Student_Management_System
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartmentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtextBoxCourseHr = new System.Windows.Forms.TextBox();
            this.textBoxtextBoxCourseID = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 143);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 609);
            this.panel1.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBoxDepartmentID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxtextBoxCourseHr);
            this.groupBox1.Controls.Add(this.textBoxtextBoxCourseID);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.AddCourseBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCourseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(457, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 374);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxDepartmentID
            // 
            this.comboBoxDepartmentID.FormattingEnabled = true;
            this.comboBoxDepartmentID.Location = new System.Drawing.Point(308, 209);
            this.comboBoxDepartmentID.Name = "comboBoxDepartmentID";
            this.comboBoxDepartmentID.Size = new System.Drawing.Size(285, 27);
            this.comboBoxDepartmentID.TabIndex = 28;
            this.comboBoxDepartmentID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartmentID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Department  ID :";
            // 
            // textBoxtextBoxCourseHr
            // 
            this.textBoxtextBoxCourseHr.Location = new System.Drawing.Point(308, 159);
            this.textBoxtextBoxCourseHr.Name = "textBoxtextBoxCourseHr";
            this.textBoxtextBoxCourseHr.Size = new System.Drawing.Size(285, 27);
            this.textBoxtextBoxCourseHr.TabIndex = 27;
            this.textBoxtextBoxCourseHr.TextChanged += new System.EventHandler(this.textBoxtextBoxCourseHr_TextChanged);
            // 
            // textBoxtextBoxCourseID
            // 
            this.textBoxtextBoxCourseID.Location = new System.Drawing.Point(308, 101);
            this.textBoxtextBoxCourseID.Name = "textBoxtextBoxCourseID";
            this.textBoxtextBoxCourseID.Size = new System.Drawing.Size(285, 27);
            this.textBoxtextBoxCourseID.TabIndex = 26;
            this.textBoxtextBoxCourseID.TextChanged += new System.EventHandler(this.textBoxtextBoxCourseID_TextChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(174, 297);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(165, 41);
            this.CancelBtn.TabIndex = 25;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddCourseBtn.FlatAppearance.BorderSize = 0;
            this.AddCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCourseBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCourseBtn.Location = new System.Drawing.Point(446, 297);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(165, 41);
            this.AddCourseBtn.TabIndex = 24;
            this.AddCourseBtn.Text = "Add";
            this.AddCourseBtn.UseVisualStyleBackColor = false;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Credit Hours :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Course ID :";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(308, 49);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(285, 27);
            this.textBoxCourseName.TabIndex = 5;
            this.textBoxCourseName.TextChanged += new System.EventHandler(this.textBoxCourseName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(457, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 62);
            this.panel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(136, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "ADD COURSE  FORM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1388, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 753);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxtextBoxCourseHr;
        private System.Windows.Forms.TextBox textBoxtextBoxCourseID;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox comboBoxDepartmentID;
    }
}