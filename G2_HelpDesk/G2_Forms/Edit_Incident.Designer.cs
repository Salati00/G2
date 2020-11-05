namespace G2_Forms
{
    partial class Edit_Incident
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_Deadline = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.DTP_reportedDate = new System.Windows.Forms.DateTimePicker();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(472, 88);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 255);
            this.txtDescription.TabIndex = 8;
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(315, 378);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(102, 46);
            this.BTN_EDIT.TabIndex = 10;
            this.BTN_EDIT.Text = "EDIT";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(527, 378);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(102, 46);
            this.BTN_Delete.TabIndex = 11;
            this.BTN_Delete.Text = "DELETE";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Reported date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Description: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Deadline/follow up:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Reported by user:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type of incident:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subject of incident:";
            // 
            // DTP_Deadline
            // 
            this.DTP_Deadline.Location = new System.Drawing.Point(207, 322);
            this.DTP_Deadline.Name = "DTP_Deadline";
            this.DTP_Deadline.Size = new System.Drawing.Size(221, 20);
            this.DTP_Deadline.TabIndex = 36;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(207, 133);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(221, 20);
            this.txtSubject.TabIndex = 35;
            // 
            // DTP_reportedDate
            // 
            this.DTP_reportedDate.Location = new System.Drawing.Point(207, 88);
            this.DTP_reportedDate.Name = "DTP_reportedDate";
            this.DTP_reportedDate.Size = new System.Drawing.Size(221, 20);
            this.DTP_reportedDate.TabIndex = 34;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(207, 279);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(221, 21);
            this.cbPriority.TabIndex = 33;
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(207, 230);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(221, 21);
            this.cbUser.TabIndex = 32;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(207, 181);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(221, 21);
            this.cbType.TabIndex = 31;
            this.cbType.Text = "Select type";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 46);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Edit_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DTP_Deadline);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.DTP_reportedDate);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.txtDescription);
            this.Name = "Edit_Incident";
            this.Text = "Edit_Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_Deadline;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.DateTimePicker DTP_reportedDate;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnCancel;
    }
}