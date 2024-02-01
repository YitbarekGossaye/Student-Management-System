
namespace Student_Management_System
{
    partial class AddDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartmentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddDepartmentBtn = new System.Windows.Forms.Button();
            this.CancelDepartmentBtn = new System.Windows.Forms.Button();
            this.textBoxDepartmentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 606);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 147);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(354, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 602);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Pink;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(74, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 62);
            this.panel4.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(136, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 55);
            this.label11.TabIndex = 1;
            this.label11.Text = "ADD DEPARTMENT  FORM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.AddDepartmentBtn);
            this.groupBox1.Controls.Add(this.CancelDepartmentBtn);
            this.groupBox1.Controls.Add(this.textBoxDepartmentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDepartmentName);
            this.groupBox1.Controls.Add(this.labelDepartmentName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 463);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // AddDepartmentBtn
            // 
            this.AddDepartmentBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AddDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.AddDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDepartmentBtn.ForeColor = System.Drawing.Color.Black;
            this.AddDepartmentBtn.Location = new System.Drawing.Point(445, 282);
            this.AddDepartmentBtn.Name = "AddDepartmentBtn";
            this.AddDepartmentBtn.Size = new System.Drawing.Size(165, 41);
            this.AddDepartmentBtn.TabIndex = 28;
            this.AddDepartmentBtn.Text = "Add";
            this.AddDepartmentBtn.UseVisualStyleBackColor = false;
            this.AddDepartmentBtn.Click += new System.EventHandler(this.AddDepartmentBtn_Click);
            // 
            // CancelDepartmentBtn
            // 
            this.CancelDepartmentBtn.BackColor = System.Drawing.Color.Coral;
            this.CancelDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.CancelDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDepartmentBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelDepartmentBtn.Location = new System.Drawing.Point(189, 282);
            this.CancelDepartmentBtn.Name = "CancelDepartmentBtn";
            this.CancelDepartmentBtn.Size = new System.Drawing.Size(165, 41);
            this.CancelDepartmentBtn.TabIndex = 27;
            this.CancelDepartmentBtn.Text = "Cancel";
            this.CancelDepartmentBtn.UseVisualStyleBackColor = false;
            this.CancelDepartmentBtn.Click += new System.EventHandler(this.CancelDepartmentBtn_Click);
            // 
            // textBoxDepartmentID
            // 
            this.textBoxDepartmentID.Location = new System.Drawing.Point(325, 144);
            this.textBoxDepartmentID.Name = "textBoxDepartmentID";
            this.textBoxDepartmentID.Size = new System.Drawing.Size(285, 27);
            this.textBoxDepartmentID.TabIndex = 26;
            this.textBoxDepartmentID.TextChanged += new System.EventHandler(this.textBoxDepartmentID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department  ID :";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(325, 73);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(285, 27);
            this.textBoxDepartmentName.TabIndex = 5;
            this.textBoxDepartmentName.TextChanged += new System.EventHandler(this.textBoxDepartmentName_TextChanged);
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(136, 76);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(162, 19);
            this.labelDepartmentName.TabIndex = 3;
            this.labelDepartmentName.Text = "Department Name :";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1365, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(64, 33);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 714);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartmentForm";
            this.Load += new System.EventHandler(this.AddDepartmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDepartmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.Button CancelDepartmentBtn;
        private System.Windows.Forms.Button AddDepartmentBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}