﻿namespace G2_Forms
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
            this.Btn_AddRow = new System.Windows.Forms.Button();
            this.UcTab_Main = new G2_UserControls.Uc_Table();
            this.SuspendLayout();
            // 
            // Btn_AddRow
            // 
            this.Btn_AddRow.Location = new System.Drawing.Point(33, 415);
            this.Btn_AddRow.Name = "Btn_AddRow";
            this.Btn_AddRow.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddRow.TabIndex = 2;
            this.Btn_AddRow.Text = "Add Row";
            this.Btn_AddRow.UseVisualStyleBackColor = true;
            this.Btn_AddRow.Click += new System.EventHandler(this.Btn_AddRow_Click);
            // 
            // UcTab_Main
            // 
            this.UcTab_Main.AutoScroll = true;
            this.UcTab_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UcTab_Main.Location = new System.Drawing.Point(33, 12);
            this.UcTab_Main.Name = "UcTab_Main";
            this.UcTab_Main.Size = new System.Drawing.Size(686, 379);
            this.UcTab_Main.TabIndex = 3;
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UcTab_Main);
            this.Controls.Add(this.Btn_AddRow);
            this.Name = "Frm_Test";
            this.Text = "Frm_Test";
            this.Load += new System.EventHandler(this.Frm_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddRow;
        private G2_UserControls.Uc_Table UcTab_Main;
    }
}