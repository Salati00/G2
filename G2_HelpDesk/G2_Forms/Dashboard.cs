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
    public partial class Dashboard : Form
    {
        public Dashboard(User admin)
        {
            InitializeComponent();
            lbl_Username.Text = admin.Firstname + " " + admin.Lastname;
        }


        private void btb_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage Logout = new LoginPage();
            Logout.ShowDialog();
            this.Close();
        }
    }
}
