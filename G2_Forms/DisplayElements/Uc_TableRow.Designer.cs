﻿namespace DisplayElements
{
    partial class Uc_TableRow
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
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(3, 15);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID";
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Location = new System.Drawing.Point(78, 15);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Subject.TabIndex = 1;
            this.Lbl_Subject.Text = "Subject";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(204, 15);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(29, 13);
            this.Lbl_User.TabIndex = 2;
            this.Lbl_User.Text = "User";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(336, 15);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Date.TabIndex = 3;
            this.Lbl_Date.Text = "Date";
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(456, 15);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Status.TabIndex = 4;
            this.Lbl_Status.Text = "Status";
            // 
            // Uc_TableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Lbl_Subject);
            this.Controls.Add(this.Lbl_ID);
            this.Name = "Uc_TableRow";
            this.Size = new System.Drawing.Size(565, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_Status;
    }
}
