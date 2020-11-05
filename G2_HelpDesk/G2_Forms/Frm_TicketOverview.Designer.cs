namespace G2_Forms
{
    partial class Frm_TicketOverview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_itemCount = new System.Windows.Forms.Label();
            this.lbl_ticketPastDeadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ClosedTickets = new System.Windows.Forms.Label();
            this.BTN_Dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket currently open ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current incidents";
            // 
            // lbl_itemCount
            // 
            this.lbl_itemCount.AutoSize = true;
            this.lbl_itemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCount.Location = new System.Drawing.Point(77, 299);
            this.lbl_itemCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itemCount.Name = "lbl_itemCount";
            this.lbl_itemCount.Size = new System.Drawing.Size(92, 55);
            this.lbl_itemCount.TabIndex = 2;
            this.lbl_itemCount.Text = "----";
            // 
            // lbl_ticketPastDeadline
            // 
            this.lbl_ticketPastDeadline.AutoSize = true;
            this.lbl_ticketPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticketPastDeadline.Location = new System.Drawing.Point(605, 299);
            this.lbl_ticketPastDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ticketPastDeadline.Name = "lbl_ticketPastDeadline";
            this.lbl_ticketPastDeadline.Size = new System.Drawing.Size(92, 55);
            this.lbl_ticketPastDeadline.TabIndex = 3;
            this.lbl_ticketPastDeadline.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tickets over deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ticket currently closed ";
            // 
            // lbl_ClosedTickets
            // 
            this.lbl_ClosedTickets.AutoSize = true;
            this.lbl_ClosedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosedTickets.Location = new System.Drawing.Point(339, 299);
            this.lbl_ClosedTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ClosedTickets.Name = "lbl_ClosedTickets";
            this.lbl_ClosedTickets.Size = new System.Drawing.Size(92, 55);
            this.lbl_ClosedTickets.TabIndex = 6;
            this.lbl_ClosedTickets.Text = "----";
            // 
            // BTN_Dashboard
            // 
            this.BTN_Dashboard.Location = new System.Drawing.Point(695, 12);
            this.BTN_Dashboard.Name = "BTN_Dashboard";
            this.BTN_Dashboard.Size = new System.Drawing.Size(95, 35);
            this.BTN_Dashboard.TabIndex = 7;
            this.BTN_Dashboard.Text = "Dashboard";
            this.BTN_Dashboard.UseVisualStyleBackColor = true;
            this.BTN_Dashboard.Click += new System.EventHandler(this.BTN_Dashboard_Click);
            // 
            // Frm_TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.BTN_Dashboard);
            this.Controls.Add(this.lbl_ClosedTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ticketPastDeadline);
            this.Controls.Add(this.lbl_itemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_TicketOverview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_itemCount;
        private System.Windows.Forms.Label lbl_ticketPastDeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ClosedTickets;
        private System.Windows.Forms.Button BTN_Dashboard;
    }
}