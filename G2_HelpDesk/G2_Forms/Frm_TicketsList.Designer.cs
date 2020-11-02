namespace G2_Forms
{
    partial class Frm_TicketsList
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
            this.FrmCom_Menu = new G2_Forms.FrmComponent_MenuBar();
            this.Uc_List = new G2_UserControls.Uc_Table();
            this.SuspendLayout();
            // 
            // FrmCom_Menu
            // 
            this.FrmCom_Menu.AutoSize = true;
            this.FrmCom_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrmCom_Menu.Location = new System.Drawing.Point(0, 0);
            this.FrmCom_Menu.Name = "FrmCom_Menu";
            this.FrmCom_Menu.Size = new System.Drawing.Size(800, 74);
            this.FrmCom_Menu.TabIndex = 0;
            this.FrmCom_Menu.Window = null;
            // 
            // Uc_List
            // 
            this.Uc_List.AutoScroll = true;
            this.Uc_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Uc_List.Location = new System.Drawing.Point(0, 80);
            this.Uc_List.Name = "Uc_List";
            this.Uc_List.Size = new System.Drawing.Size(800, 370);
            this.Uc_List.TabIndex = 1;
            // 
            // Frm_TicketsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uc_List);
            this.Controls.Add(this.FrmCom_Menu);
            this.Name = "Frm_TicketsList";
            this.Text = "Frm_TicketsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrmComponent_MenuBar FrmCom_Menu;
        private G2_UserControls.Uc_Table Uc_List;
    }
}