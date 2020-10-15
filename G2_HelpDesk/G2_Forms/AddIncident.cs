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
            Incident incident = new Incident();
            
            InitializeComponent();
            cbDeadline.Items.Add(1);
            cbDeadline.Items.Add(2);
            cbDeadline.Items.Add(3);
            cbDeadline.Items.Add(4);
            //enums were changed look at the Incident model again
            //cbType.DataSource = Enum.GetValues(typeof(Incident.Type));
            //cbPriority.DataSource = Enum.GetValues(typeof(Incident.Priority));


        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
