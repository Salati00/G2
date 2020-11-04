namespace G2_Forms
{
    partial class Frm_TicketList
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
            this.Uc_Menu = new G2_Forms.Uc_MenuBar();
            this.Uc_List = new G2_Forms.Uc_Table();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uc_Menu
            // 
            this.Uc_Menu.AutoSize = true;
            this.Uc_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Uc_Menu.Location = new System.Drawing.Point(0, 0);
            this.Uc_Menu.Name = "Uc_Menu";
            this.Uc_Menu.Size = new System.Drawing.Size(800, 74);
            this.Uc_Menu.TabIndex = 3;
            this.Uc_Menu.Window = null;
            // 
            // Uc_List
            // 
            this.Uc_List.AutoScroll = true;
            this.Uc_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Uc_List.Location = new System.Drawing.Point(0, 75);
            this.Uc_List.Name = "Uc_List";
            this.Uc_List.Size = new System.Drawing.Size(800, 375);
            this.Uc_List.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Uc_Menu);
            this.Controls.Add(this.Uc_List);
            this.Name = "Frm_TicketList";
            this.Text = "Frm_TicketList";
            this.Load += new System.EventHandler(this.Frm_TicketList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uc_Table Uc_List;
        private Uc_MenuBar Uc_Menu;
        private System.Windows.Forms.Button button1;
    }
}