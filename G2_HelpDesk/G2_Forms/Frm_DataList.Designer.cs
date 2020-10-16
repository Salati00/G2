namespace G2_Forms
{
    partial class Frm_DataList
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
            this.Uc_TableMain = new G2_UserControls.Uc_Table();
            this.SuspendLayout();
            // 
            // Uc_TableMain
            // 
            this.Uc_TableMain.AutoScroll = true;
            this.Uc_TableMain.AutoSize = true;
            this.Uc_TableMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Uc_TableMain.Location = new System.Drawing.Point(0, 0);
            this.Uc_TableMain.Name = "Uc_TableMain";
            this.Uc_TableMain.Size = new System.Drawing.Size(839, 521);
            this.Uc_TableMain.TabIndex = 0;
            // 
            // Frm_DataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 521);
            this.Controls.Add(this.Uc_TableMain);
            this.Name = "Frm_DataList";
            this.Text = "Frm_DataList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private G2_UserControls.Uc_Table Uc_TableMain;
    }
}