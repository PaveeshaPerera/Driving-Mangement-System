namespace Driving_Managment_System
{
    partial class newinvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 321);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1013, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 91;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtDueDate);
            this.panel2.Controls.Add(this.txtIssueDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCourseFee);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtStudentID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtStudentName);
            this.panel2.Location = new System.Drawing.Point(3, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 277);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(977, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 91;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(173, 233);
            this.txtDueDate.MaxDate = new System.DateTime(2027, 12, 9, 0, 0, 0, 0);
            this.txtDueDate.MinDate = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(200, 22);
            this.txtDueDate.TabIndex = 90;
            this.txtDueDate.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(173, 177);
            this.txtIssueDate.MaxDate = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            this.txtIssueDate.MinDate = new System.DateTime(2000, 12, 9, 0, 0, 0, 0);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(200, 22);
            this.txtIssueDate.TabIndex = 89;
            this.txtIssueDate.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Issue Date";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnedit.Location = new System.Drawing.Point(977, 155);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(150, 44);
            this.btnedit.TabIndex = 86;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Location = new System.Drawing.Point(977, 90);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 44);
            this.btnadd.TabIndex = 85;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(591, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDiscount.Location = new System.Drawing.Point(693, 215);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(227, 29);
            this.txtDiscount.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Course Fee";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCourseFee.Location = new System.Drawing.Point(693, 145);
            this.txtCourseFee.Multiline = true;
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(227, 29);
            this.txtCourseFee.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(606, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Course";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCourseName.Location = new System.Drawing.Point(693, 79);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(227, 29);
            this.txtCourseName.TabIndex = 79;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsearch.Location = new System.Drawing.Point(424, 27);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(126, 31);
            this.btnsearch.TabIndex = 78;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStudentID.Location = new System.Drawing.Point(173, 25);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(175, 29);
            this.txtStudentID.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 73;
            this.label13.Text = "Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStudentName.Location = new System.Drawing.Point(173, 88);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(234, 57);
            this.txtStudentName.TabIndex = 72;
            // 
            // newinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "newinvoice";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDueDate;
        private System.Windows.Forms.DateTimePicker txtIssueDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
