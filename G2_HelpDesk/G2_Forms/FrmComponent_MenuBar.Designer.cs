namespace G2_Forms
{
    partial class FrmComponent_MenuBar
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
            this.Btn_DashBoard = new System.Windows.Forms.Button();
            this.Btn_Users = new System.Windows.Forms.Button();
            this.Btn_Tickets = new System.Windows.Forms.Button();
            this.Lbl_NoDesk = new System.Windows.Forms.Label();
            this.Lbl_Licensed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_DashBoard
            // 
            this.Btn_DashBoard.Location = new System.Drawing.Point(3, 48);
            this.Btn_DashBoard.Name = "Btn_DashBoard";
            this.Btn_DashBoard.Size = new System.Drawing.Size(75, 23);
            this.Btn_DashBoard.TabIndex = 0;
            this.Btn_DashBoard.Text = "Dashboard";
            this.Btn_DashBoard.UseVisualStyleBackColor = true;
            this.Btn_DashBoard.Click += new System.EventHandler(this.Btn_DashBoard_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.Location = new System.Drawing.Point(722, 48);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(75, 23);
            this.Btn_Users.TabIndex = 1;
            this.Btn_Users.Text = "Employees";
            this.Btn_Users.UseVisualStyleBackColor = true;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // Btn_Tickets
            // 
            this.Btn_Tickets.Location = new System.Drawing.Point(361, 48);
            this.Btn_Tickets.Name = "Btn_Tickets";
            this.Btn_Tickets.Size = new System.Drawing.Size(75, 23);
            this.Btn_Tickets.TabIndex = 2;
            this.Btn_Tickets.Text = "Tickets";
            this.Btn_Tickets.UseVisualStyleBackColor = true;
            this.Btn_Tickets.Click += new System.EventHandler(this.Btn_Tickets_Click);
            // 
            // Lbl_NoDesk
            // 
            this.Lbl_NoDesk.AutoSize = true;
            this.Lbl_NoDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoDesk.Location = new System.Drawing.Point(697, 0);
            this.Lbl_NoDesk.Name = "Lbl_NoDesk";
            this.Lbl_NoDesk.Size = new System.Drawing.Size(100, 29);
            this.Lbl_NoDesk.TabIndex = 3;
            this.Lbl_NoDesk.Text = "NoDesk";
            // 
            // Lbl_Licensed
            // 
            this.Lbl_Licensed.AutoSize = true;
            this.Lbl_Licensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Licensed.Location = new System.Drawing.Point(629, 29);
            this.Lbl_Licensed.Name = "Lbl_Licensed";
            this.Lbl_Licensed.Size = new System.Drawing.Size(168, 16);
            this.Lbl_Licensed.TabIndex = 4;
            this.Lbl_Licensed.Text = "Licensed to: Garden Group";
            // 
            // FrmComponent_MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Lbl_Licensed);
            this.Controls.Add(this.Lbl_NoDesk);
            this.Controls.Add(this.Btn_Tickets);
            this.Controls.Add(this.Btn_Users);
            this.Controls.Add(this.Btn_DashBoard);
            this.Name = "FrmComponent_MenuBar";
            this.Size = new System.Drawing.Size(800, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DashBoard;
        private System.Windows.Forms.Button Btn_Users;
        private System.Windows.Forms.Button Btn_Tickets;
        private System.Windows.Forms.Label Lbl_NoDesk;
        private System.Windows.Forms.Label Lbl_Licensed;
    }
}
