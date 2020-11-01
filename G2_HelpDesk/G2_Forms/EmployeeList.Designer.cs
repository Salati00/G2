using G2_Model;
namespace G2_Forms
{
    partial class EmployeeList
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
            this.UC_employeeList = new G2_UserControls.Uc_Table(typeof(Person));
            this.SuspendLayout();
            // 
            // UC_employeeList
            // 
            this.UC_employeeList.AutoScroll = true;
            this.UC_employeeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_employeeList.Location = new System.Drawing.Point(0, 0);
            this.UC_employeeList.Name = "UC_employeeList";
            this.UC_employeeList.Size = new System.Drawing.Size(800, 450);
            this.UC_employeeList.TabIndex = 0;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UC_employeeList);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private G2_UserControls.Uc_Table UC_employeeList;
    }
}