namespace G2_Forms
{
    partial class AccountInfo
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
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_editAccount = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(62, 35);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.ReadOnly = true;
            this.txt_firstname.Size = new System.Drawing.Size(304, 20);
            this.txt_firstname.TabIndex = 0;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(62, 91);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.ReadOnly = true;
            this.txt_lastname.Size = new System.Drawing.Size(304, 20);
            this.txt_lastname.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(62, 286);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(304, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(62, 191);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.ReadOnly = true;
            this.txt_phonenumber.Size = new System.Drawing.Size(304, 20);
            this.txt_phonenumber.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(62, 142);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(304, 20);
            this.txt_email.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(62, 342);
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = true;
            this.txt_password.Size = new System.Drawing.Size(304, 20);
            this.txt_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lastname";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(59, 270);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(59, 326);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phonenumber";
            // 
            // btn_editAccount
            // 
            this.btn_editAccount.Location = new System.Drawing.Point(62, 383);
            this.btn_editAccount.Name = "btn_editAccount";
            this.btn_editAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_editAccount.TabIndex = 12;
            this.btn_editAccount.Text = "Edit";
            this.btn_editAccount.UseVisualStyleBackColor = true;
            this.btn_editAccount.Click += new System.EventHandler(this.Btn_editAccount_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(291, 383);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 13;
            this.Btn_Confirm.Text = "Confirm";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(461, 383);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.btn_editAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Name = "AccountInfo";
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_editAccount;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button btn_Delete;
    }
}