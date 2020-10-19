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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_CreateUser = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "NewIncident";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Current Incidents";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 73);
            this.button3.TabIndex = 4;
            this.button3.Text = "Account";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Location = new System.Drawing.Point(254, 254);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(269, 73);
            this.btn_CreateUser.TabIndex = 5;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btb_Logout);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btb_Logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_CreateUser;
    }
}