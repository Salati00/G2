using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Model;



namespace G2_Forms
{
    public partial class AddIncident : Form
    {
        public AddIncident()
        {
            Ticket incident = new Ticket();
            
            InitializeComponent();
            cbDeadline.Items.Add(1);
            cbDeadline.Items.Add(2);
            cbDeadline.Items.Add(3);
            cbDeadline.Items.Add(4);
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));


        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            //TicketTypes type = cbType.SelectedItem.GetType;
        }
    }
}
