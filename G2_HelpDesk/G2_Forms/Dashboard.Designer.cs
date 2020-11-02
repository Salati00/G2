namespace G2_Forms
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btb_Logout = new System.Windows.Forms.Button();
            this.Btn_IncidentList = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btb_EmployeeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(12, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(22, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "-----";
            // 
            // btb_Logout
            // 
            this.btb_Logout.Location = new System.Drawing.Point(723, 4);
            this.btb_Logout.Name = "btb_Logout";
            this.btb_Logout.Size = new System.Drawing.Size(75, 23);
            this.btb_Logout.TabIndex = 1;
            this.btb_Logout.Text = "Logout";
            this.btb_Logout.UseVisualStyleBackColor = true;
            this.btb_Logout.Click += new System.EventHandler(this.btb_Logout_Click);
            // 
            // Btn_IncidentList
            // 
            this.Btn_IncidentList.Location = new System.Drawing.Point(254, 83);
            this.Btn_IncidentList.Name = "Btn_IncidentList";
            this.Btn_IncidentList.Size = new System.Drawing.Size(269, 73);
            this.Btn_IncidentList.TabIndex = 3;
            this.Btn_IncidentList.Text = "View Current Incidents";
            this.Btn_IncidentList.UseVisualStyleBackColor = true;
            this.Btn_IncidentList.Click += new System.EventHandler(this.Btn_IncidentList_Click);
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(723, 33);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(75, 23);
            this.btn_account.TabIndex = 4;
            this.btn_account.Text = "Account";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btb_EmployeeList
            // 
            this.btb_EmployeeList.Location = new System.Drawing.Point(254, 225);
            this.btb_EmployeeList.Name = "btb_EmployeeList";
            this.btb_EmployeeList.Size = new System.Drawing.Size(269, 73);
            this.btb_EmployeeList.TabIndex = 6;
            this.btb_EmployeeList.Text = "Employee Management";
            this.btb_EmployeeList.UseVisualStyleBackColor = true;
            this.btb_EmployeeList.Click += new System.EventHandler(this.btb_EmployeeList_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btb_EmployeeList);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.Btn_IncidentList);
            this.Controls.Add(this.btb_Logout);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btb_Logout;
        private System.Windows.Forms.Button Btn_IncidentList;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btb_EmployeeList;
    }
}