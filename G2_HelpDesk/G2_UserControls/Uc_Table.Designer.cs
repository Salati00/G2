namespace G2_UserControls
{
    partial class Uc_Table
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Txt_Filter = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Tmr_Filter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(495, 48);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Status.TabIndex = 14;
            this.Lbl_Status.Text = "Status";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(375, 48);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Date.TabIndex = 13;
            this.Lbl_Date.Text = "Date";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(243, 48);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(29, 13);
            this.Lbl_User.TabIndex = 12;
            this.Lbl_User.Text = "User";
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Location = new System.Drawing.Point(117, 48);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Subject.TabIndex = 11;
            this.Lbl_Subject.Text = "Subject";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(46, 48);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.Lbl_ID.TabIndex = 10;
            this.Lbl_ID.Text = "ID";
            // 
            // Txt_Filter
            // 
            this.Txt_Filter.Location = new System.Drawing.Point(23, 12);
            this.Txt_Filter.Name = "Txt_Filter";
            this.Txt_Filter.Size = new System.Drawing.Size(175, 20);
            this.Txt_Filter.TabIndex = 15;
            this.Txt_Filter.TextChanged += new System.EventHandler(this.Txt_Filter_TextChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(568, 10);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 16;
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Tmr_Filter
            // 
            this.Tmr_Filter.Interval = 2000;
            this.Tmr_Filter.Tick += new System.EventHandler(this.Tmr_Filter_Tick);
            // 
            // Uc_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Filter);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Lbl_Subject);
            this.Controls.Add(this.Lbl_ID);
            this.Name = "Uc_Table";
            this.Size = new System.Drawing.Size(686, 379);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.TextBox Txt_Filter;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Timer Tmr_Filter;
    }
}
