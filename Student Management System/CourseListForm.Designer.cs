
namespace Student_Management_System
{
    partial class CourseListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseListForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCourseList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalcourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteSelectedCourseBtn = new System.Windows.Forms.Button();
            this.UpdateSelectedbutton = new System.Windows.Forms.Button();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 144);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 574);
            this.panel1.TabIndex = 4;
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
            // dataGridViewCourseList
            // 
            this.dataGridViewCourseList.AllowUserToAddRows = false;
            this.dataGridViewCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCourseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCourseList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseList.Location = new System.Drawing.Point(367, 116);
            this.dataGridViewCourseList.Name = "dataGridViewCourseList";
            this.dataGridViewCourseList.ReadOnly = true;
            this.dataGridViewCourseList.Size = new System.Drawing.Size(1000, 400);
            this.dataGridViewCourseList.TabIndex = 14;
            this.dataGridViewCourseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourseList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelTotalcourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(658, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 61);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalcourse
            // 
            this.labelTotalcourse.Location = new System.Drawing.Point(147, 23);
            this.labelTotalcourse.Name = "labelTotalcourse";
            this.labelTotalcourse.Size = new System.Drawing.Size(70, 19);
            this.labelTotalcourse.TabIndex = 17;
            this.labelTotalcourse.Click += new System.EventHandler(this.labelTotalcourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Course :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(367, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 63);
            this.panel3.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(220, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "COURSE LIST ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteSelectedCourseBtn
            // 
            this.DeleteSelectedCourseBtn.BackColor = System.Drawing.Color.Salmon;
            this.DeleteSelectedCourseBtn.FlatAppearance.BorderSize = 0;
            this.DeleteSelectedCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedCourseBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedCourseBtn.Location = new System.Drawing.Point(445, 619);
            this.DeleteSelectedCourseBtn.Name = "DeleteSelectedCourseBtn";
            this.DeleteSelectedCourseBtn.Size = new System.Drawing.Size(165, 41);
            this.DeleteSelectedCourseBtn.TabIndex = 26;
            this.DeleteSelectedCourseBtn.Text = "Delete";
            this.DeleteSelectedCourseBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedCourseBtn.Click += new System.EventHandler(this.DeleteSelectedCourseBtn_Click);
            // 
            // UpdateSelectedbutton
            // 
            this.UpdateSelectedbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpdateSelectedbutton.FlatAppearance.BorderSize = 0;
            this.UpdateSelectedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSelectedbutton.ForeColor = System.Drawing.Color.Black;
            this.UpdateSelectedbutton.Location = new System.Drawing.Point(809, 619);
            this.UpdateSelectedbutton.Name = "UpdateSelectedbutton";
            this.UpdateSelectedbutton.Size = new System.Drawing.Size(165, 41);
            this.UpdateSelectedbutton.TabIndex = 27;
            this.UpdateSelectedbutton.Text = "Update";
            this.UpdateSelectedbutton.UseVisualStyleBackColor = false;
            this.UpdateSelectedbutton.Click += new System.EventHandler(this.UpdateSelectedbutton_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddCourseBtn.FlatAppearance.BorderSize = 0;
            this.AddCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCourseBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCourseBtn.Location = new System.Drawing.Point(1137, 619);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(165, 41);
            this.AddCourseBtn.TabIndex = 28;
            this.AddCourseBtn.Text = "Add";
            this.AddCourseBtn.UseVisualStyleBackColor = false;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1372, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CourseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.UpdateSelectedbutton);
            this.Controls.Add(this.DeleteSelectedCourseBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCourseList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CourseListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseListForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCourseList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalcourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteSelectedCourseBtn;
        private System.Windows.Forms.Button UpdateSelectedbutton;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}