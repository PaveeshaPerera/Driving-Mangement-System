namespace Driving_Managment_System
{
    partial class newreceipt
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
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtThisPayment = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewReceipt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 294);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(979, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 92;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(11, 44);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowHeadersWidth = 51;
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(1112, 232);
            this.dataGridViewReceipt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receipt Data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtReceiptID);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtRemainingBalance);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtThisPayment);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtCourseFee);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtCourse);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtInvoiceID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSID);
            this.panel2.Location = new System.Drawing.Point(16, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 307);
            this.panel2.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsearch.Location = new System.Drawing.Point(244, 44);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(126, 31);
            this.btnsearch.TabIndex = 114;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnedit.Location = new System.Drawing.Point(955, 250);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(150, 44);
            this.btnedit.TabIndex = 113;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Location = new System.Drawing.Point(955, 192);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 44);
            this.btnadd.TabIndex = 112;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Receipt ID";
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReceiptID.Location = new System.Drawing.Point(20, 44);
            this.txtReceiptID.Multiline = true;
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(174, 23);
            this.txtReceiptID.TabIndex = 109;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(448, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 108;
            this.label15.Text = "Total (Rs)";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotal.Location = new System.Drawing.Point(451, 126);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(175, 29);
            this.txtTotal.TabIndex = 107;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(792, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 16);
            this.label18.TabIndex = 106;
            this.label18.Text = "Remaining Balance (Rs)";
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRemainingBalance.Location = new System.Drawing.Point(795, 126);
            this.txtRemainingBalance.Multiline = true;
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.Size = new System.Drawing.Size(175, 29);
            this.txtRemainingBalance.TabIndex = 105;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(792, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 16);
            this.label19.TabIndex = 104;
            this.label19.Text = "This Payment (Rs)";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtThisPayment
            // 
            this.txtThisPayment.BackColor = System.Drawing.Color.Gainsboro;
            this.txtThisPayment.Location = new System.Drawing.Point(795, 39);
            this.txtThisPayment.Multiline = true;
            this.txtThisPayment.Name = "txtThisPayment";
            this.txtThisPayment.Size = new System.Drawing.Size(175, 29);
            this.txtThisPayment.TabIndex = 103;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(681, 252);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 20);
            this.radioButton3.TabIndex = 102;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Debit Card";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(558, 250);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 20);
            this.radioButton2.TabIndex = 101;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Credit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(465, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 20);
            this.radioButton1.TabIndex = 100;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(448, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 94;
            this.label12.Text = "Course Fee";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCourseFee.Location = new System.Drawing.Point(451, 39);
            this.txtCourseFee.Multiline = true;
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(226, 23);
            this.txtCourseFee.TabIndex = 93;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 92;
            this.label14.Text = "Course";
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCourse.Location = new System.Drawing.Point(20, 252);
            this.txtCourse.Multiline = true;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(174, 23);
            this.txtCourse.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Invoice ID";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInvoiceID.Location = new System.Drawing.Point(20, 182);
            this.txtInvoiceID.Multiline = true;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(226, 23);
            this.txtInvoiceID.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "SID";
            // 
            // txtSID
            // 
            this.txtSID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSID.Location = new System.Drawing.Point(22, 109);
            this.txtSID.Multiline = true;
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(174, 23);
            this.txtSID.TabIndex = 85;
            // 
            // newreceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "newreceipt";
            this.Size = new System.Drawing.Size(1189, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRemainingBalance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtThisPayment;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Button button1;
    }
}
