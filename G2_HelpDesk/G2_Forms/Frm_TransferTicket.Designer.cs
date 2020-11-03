namespace G2_Forms
{
    partial class Frm_TransferTicket
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Select_User = new System.Windows.Forms.Label();
            this.cmb_selectUser = new System.Windows.Forms.ComboBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_transfer_to = new System.Windows.Forms.Label();
            this.ticket_subject = new System.Windows.Forms.Label();
            this.ticket_description = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.Label();
            this.transferFrom = new System.Windows.Forms.Label();
            this.transfer_to = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(93, 34);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(392, 35);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Transfer Ticket to a Different User";
            // 
            // lbl_Select_User
            // 
            this.lbl_Select_User.AutoSize = true;
            this.lbl_Select_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select_User.Location = new System.Drawing.Point(295, 124);
            this.lbl_Select_User.Name = "lbl_Select_User";
            this.lbl_Select_User.Size = new System.Drawing.Size(106, 24);
            this.lbl_Select_User.TabIndex = 2;
            this.lbl_Select_User.Text = "Select User";
            // 
            // cmb_selectUser
            // 
            this.cmb_selectUser.FormattingEnabled = true;
            this.cmb_selectUser.Location = new System.Drawing.Point(407, 126);
            this.cmb_selectUser.Name = "cmb_selectUser";
            this.cmb_selectUser.Size = new System.Drawing.Size(121, 24);
            this.cmb_selectUser.TabIndex = 3;
            this.cmb_selectUser.SelectedIndexChanged += new System.EventHandler(this.cmb_selectUser_SelectedIndexChanged);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.Location = new System.Drawing.Point(299, 174);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(238, 70);
            this.btn_transfer.TabIndex = 4;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket Subject: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.MinimumSize = new System.Drawing.Size(125, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket Description: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deadline: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transfer From: ";
            // 
            // lbl_transfer_to
            // 
            this.lbl_transfer_to.AutoSize = true;
            this.lbl_transfer_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transfer_to.Location = new System.Drawing.Point(295, 100);
            this.lbl_transfer_to.Name = "lbl_transfer_to";
            this.lbl_transfer_to.Size = new System.Drawing.Size(91, 17);
            this.lbl_transfer_to.TabIndex = 9;
            this.lbl_transfer_to.Text = "Transfer To: ";
            // 
            // ticket_subject
            // 
            this.ticket_subject.AutoEllipsis = true;
            this.ticket_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_subject.Location = new System.Drawing.Point(152, 100);
            this.ticket_subject.Name = "ticket_subject";
            this.ticket_subject.Size = new System.Drawing.Size(125, 17);
            this.ticket_subject.TabIndex = 10;
            // 
            // ticket_description
            // 
            this.ticket_description.AutoEllipsis = true;
            this.ticket_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_description.Location = new System.Drawing.Point(154, 124);
            this.ticket_description.Name = "ticket_description";
            this.ticket_description.Size = new System.Drawing.Size(125, 17);
            this.ticket_description.TabIndex = 11;
            // 
            // deadline
            // 
            this.deadline.AutoEllipsis = true;
            this.deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadline.Location = new System.Drawing.Point(154, 148);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(125, 17);
            this.deadline.TabIndex = 12;
            // 
            // transferFrom
            // 
            this.transferFrom.AutoEllipsis = true;
            this.transferFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFrom.Location = new System.Drawing.Point(154, 174);
            this.transferFrom.Name = "transferFrom";
            this.transferFrom.Size = new System.Drawing.Size(125, 17);
            this.transferFrom.TabIndex = 13;
            // 
            // transfer_to
            // 
            this.transfer_to.AutoSize = true;
            this.transfer_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer_to.Location = new System.Drawing.Point(394, 100);
            this.transfer_to.Name = "transfer_to";
            this.transfer_to.Size = new System.Drawing.Size(0, 17);
            this.transfer_to.TabIndex = 14;
            // 
            // Frm_TransferTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 296);
            this.Controls.Add(this.transfer_to);
            this.Controls.Add(this.transferFrom);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.ticket_description);
            this.Controls.Add(this.ticket_subject);
            this.Controls.Add(this.lbl_transfer_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.cmb_selectUser);
            this.Controls.Add(this.lbl_Select_User);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Frm_TransferTicket";
            this.Text = "Transfer Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Select_User;
        private System.Windows.Forms.ComboBox cmb_selectUser;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_transfer_to;
        private System.Windows.Forms.Label ticket_subject;
        private System.Windows.Forms.Label ticket_description;
        private System.Windows.Forms.Label deadline;
        private System.Windows.Forms.Label transferFrom;
        private System.Windows.Forms.Label transfer_to;
    }
}