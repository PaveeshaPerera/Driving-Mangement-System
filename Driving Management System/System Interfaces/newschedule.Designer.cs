namespace Driving_Managment_System
{
    partial class newschedule
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
            this.schedulepanal = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedulepanal
            // 
            this.schedulepanal.Location = new System.Drawing.Point(0, 65);
            this.schedulepanal.Name = "schedulepanal";
            this.schedulepanal.Size = new System.Drawing.Size(1186, 591);
            this.schedulepanal.TabIndex = 0;
            this.schedulepanal.Paint += new System.Windows.Forms.PaintEventHandler(this.schedulepanal_Paint);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(29, 15);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 44);
            this.btnadd.TabIndex = 87;
            this.btnadd.Text = "Lectures";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 44);
            this.button1.TabIndex = 88;
            this.button1.Text = "Driving Sessions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.schedulepanal);
            this.Name = "newschedule";
            this.Size = new System.Drawing.Size(1189, 659);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel schedulepanal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}
