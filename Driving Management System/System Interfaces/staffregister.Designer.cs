namespace Driving_Managment_System
{
    partial class staffregister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(587, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 604);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(423, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 92;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 490);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbRole);
            this.panel2.Controls.Add(this.txtNIC);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.dtpHireDate);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtStaffID);
            this.panel2.Location = new System.Drawing.Point(19, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 604);
            this.panel2.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Receptionist",
            "Student Cordinator",
            "Lecturer",
            "Instructor"});
            this.cmbRole.Location = new System.Drawing.Point(203, 492);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(185, 24);
            this.cmbRole.TabIndex = 232;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNIC.Location = new System.Drawing.Point(203, 215);
            this.txtNIC.Multiline = true;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(236, 29);
            this.txtNIC.TabIndex = 231;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnclear.Location = new System.Drawing.Point(425, 554);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 36);
            this.btnclear.TabIndex = 230;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(203, 354);
            this.dtpHireDate.MaxDate = new System.DateTime(2031, 12, 29, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1960, 12, 25, 23, 59, 59, 999);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 22);
            this.dtpHireDate.TabIndex = 94;
            this.dtpHireDate.Value = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(203, 293);
            this.dtpDOB.MaxDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 999);
            this.dtpDOB.MinDate = new System.DateTime(1940, 12, 25, 23, 59, 59, 999);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 93;
            this.dtpDOB.Value = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Location = new System.Drawing.Point(203, 85);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 29);
            this.txtName.TabIndex = 92;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(203, 416);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 29);
            this.txtEmail.TabIndex = 91;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndelete.Location = new System.Drawing.Point(296, 554);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(107, 38);
            this.btndelete.TabIndex = 89;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnedit.Location = new System.Drawing.Point(151, 554);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(109, 38);
            this.btnedit.TabIndex = 88;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Location = new System.Drawing.Point(8, 554);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(108, 38);
            this.btnadd.TabIndex = 87;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContact.Location = new System.Drawing.Point(203, 147);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(236, 29);
            this.txtContact.TabIndex = 62;
            this.txtContact.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Staff Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Hire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "NIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contact No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Staff ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Name";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStaffID.Location = new System.Drawing.Point(203, 20);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(236, 29);
            this.txtStaffID.TabIndex = 48;
            this.txtStaffID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // staffregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "staffregister";
            this.Size = new System.Drawing.Size(1189, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}
