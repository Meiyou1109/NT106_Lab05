
namespace Lab05
{
    partial class Dashboard
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
            this.lblDB = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEx02 = new System.Windows.Forms.Button();
            this.btnEx01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.ForeColor = System.Drawing.Color.Red;
            this.lblDB.Location = new System.Drawing.Point(165, 57);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(258, 35);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "Exercises Lab05";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(218, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 52);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEx02
            // 
            this.btnEx02.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx02.Location = new System.Drawing.Point(352, 167);
            this.btnEx02.Name = "btnEx02";
            this.btnEx02.Size = new System.Drawing.Size(149, 52);
            this.btnEx02.TabIndex = 11;
            this.btnEx02.Text = "Exercise02";
            this.btnEx02.UseVisualStyleBackColor = true;
            this.btnEx02.Click += new System.EventHandler(this.btnEx02_Click);
            // 
            // btnEx01
            // 
            this.btnEx01.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx01.Location = new System.Drawing.Point(91, 167);
            this.btnEx01.Name = "btnEx01";
            this.btnEx01.Size = new System.Drawing.Size(149, 52);
            this.btnEx01.TabIndex = 13;
            this.btnEx01.Text = "Exercise01";
            this.btnEx01.UseVisualStyleBackColor = true;
            this.btnEx01.Click += new System.EventHandler(this.btnEx01_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 390);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEx02);
            this.Controls.Add(this.btnEx01);
            this.Controls.Add(this.lblDB);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEx02;
        private System.Windows.Forms.Button btnEx01;
    }
}