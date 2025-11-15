namespace Driving_Managment_System
{
    partial class viewreceipts
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewReceipt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 580);
            this.panel1.TabIndex = 115;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(966, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 92;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(20, 175);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowHeadersWidth = 51;
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(1089, 370);
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
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsearch.Location = new System.Drawing.Point(390, 41);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(126, 31);
            this.btnsearch.TabIndex = 118;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "Receipt ID";
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReceiptID.Location = new System.Drawing.Point(166, 45);
            this.txtReceiptID.Multiline = true;
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(174, 23);
            this.txtReceiptID.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtReceiptID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(216, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 100);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Receipt ID";
            // 
            // viewreceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "viewreceipts";
            this.Size = new System.Drawing.Size(1189, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
