namespace G2_Forms
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
            this.Txt_Filter = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Tmr_Filter = new System.Windows.Forms.Timer(this.components);
            this.Chk_Sort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.Btn_Add.Location = new System.Drawing.Point(583, 10);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(103, 23);
            this.Btn_Add.TabIndex = 16;
            this.Btn_Add.Text = "Add new to db";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Visible = false;
            // 
            // Tmr_Filter
            // 
            this.Tmr_Filter.Interval = 250;
            this.Tmr_Filter.Tick += new System.EventHandler(this.Tmr_Filter_Tick);
            // 
            // Chk_Sort
            // 
            this.Chk_Sort.AutoSize = true;
            this.Chk_Sort.Location = new System.Drawing.Point(273, 14);
            this.Chk_Sort.Name = "Chk_Sort";
            this.Chk_Sort.Size = new System.Drawing.Size(93, 17);
            this.Chk_Sort.TabIndex = 17;
            this.Chk_Sort.Text = "Sort by Priority";
            this.Chk_Sort.UseVisualStyleBackColor = true;
            this.Chk_Sort.CheckedChanged += new System.EventHandler(this.Chk_Sort_CheckedChanged);
            // 
            // Uc_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chk_Sort);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Filter);
            this.Name = "Uc_Table";
            this.Size = new System.Drawing.Size(726, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Filter;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Timer Tmr_Filter;
        private System.Windows.Forms.CheckBox Chk_Sort;
    }
}
