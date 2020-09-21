namespace G2_Forms
{
    partial class Frm_Test
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
            this.UcTab_Main = new DisplayElements.Uc_Table();
            this.Btn_AddRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UcTab_Main
            // 
            this.UcTab_Main.Location = new System.Drawing.Point(13, 13);
            this.UcTab_Main.Name = "UcTab_Main";
            this.UcTab_Main.Size = new System.Drawing.Size(622, 330);
            this.UcTab_Main.TabIndex = 0;
            // 
            // Btn_AddRow
            // 
            this.Btn_AddRow.Location = new System.Drawing.Point(43, 380);
            this.Btn_AddRow.Name = "Btn_AddRow";
            this.Btn_AddRow.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddRow.TabIndex = 1;
            this.Btn_AddRow.Text = "Add Row";
            this.Btn_AddRow.UseVisualStyleBackColor = true;
            this.Btn_AddRow.Click += new System.EventHandler(this.Btn_AddRow_Click);
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.Btn_AddRow);
            this.Controls.Add(this.UcTab_Main);
            this.Name = "Frm_Test";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DisplayElements.Uc_Table UcTab_Main;
        private System.Windows.Forms.Button Btn_AddRow;
    }
}