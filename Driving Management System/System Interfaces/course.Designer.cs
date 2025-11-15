namespace Driving_Managment_System
{
    partial class course
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
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcourseid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.txtdescrip);
            this.panel1.Controls.Add(this.txtduration);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtfee);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 630);
            this.panel1.TabIndex = 0;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(923, 509);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(204, 22);
            this.txtdiscount.TabIndex = 232;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(776, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 231;
            this.label8.Text = "Discount";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview.Location = new System.Drawing.Point(20, 434);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(162, 47);
            this.btnview.TabIndex = 230;
            this.btnview.Text = "VIEW COURSES";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnclear.Location = new System.Drawing.Point(965, 562);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 47);
            this.btnclear.TabIndex = 229;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(923, 350);
            this.txtdescrip.Multiline = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(204, 127);
            this.txtdescrip.TabIndex = 228;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(923, 298);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(204, 22);
            this.txtduration.TabIndex = 227;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(923, 191);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(204, 22);
            this.txtname.TabIndex = 225;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(923, 245);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(204, 22);
            this.txtfee.TabIndex = 226;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtcourseid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(766, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 127);
            this.groupBox1.TabIndex = 224;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Course";
            // 
            // txtcourseid
            // 
            this.txtcourseid.Location = new System.Drawing.Point(157, 35);
            this.txtcourseid.Name = "txtcourseid";
            this.txtcourseid.Size = new System.Drawing.Size(189, 28);
            this.txtcourseid.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "Course ID";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnsearch.Location = new System.Drawing.Point(234, 80);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(112, 28);
            this.btnsearch.TabIndex = 104;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 223;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(776, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 222;
            this.label5.Text = "Course Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 221;
            this.label4.Text = "Course Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 220;
            this.label3.Text = "Course Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 398);
            this.dataGridView1.TabIndex = 219;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnedit.Location = new System.Drawing.Point(471, 562);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(162, 47);
            this.btnedit.TabIndex = 218;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndelete.Location = new System.Drawing.Point(717, 562);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(162, 47);
            this.btndelete.TabIndex = 217;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Location = new System.Drawing.Point(232, 562);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(162, 47);
            this.btnadd.TabIndex = 216;
            this.btnadd.Text = "ADD ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "course";
            this.Size = new System.Drawing.Size(1189, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcourseid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
    }
}
