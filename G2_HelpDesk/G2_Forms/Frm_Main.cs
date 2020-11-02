using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;

namespace G2_Forms
{
    public partial class Frm_Main : Form
    {
        const int DEBUGMODE = 1;

        public Frm_Main()
        {
            InitializeComponent();

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            SetDebug();

        }

        //  Function to update whenever something for debug is added,
        //  changes debug elements to active (DEBUGMODE == 1) or inactive (DEBUGMODE == 0)
        private void SetDebug()
        {
            Btn_Test.Enabled = (DEBUGMODE == 1);
            Btn_Test.Visible = (DEBUGMODE == 1);
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            Frm_Test f = new Frm_Test();
            f.ShowDialog();
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            Overview o = new Overview();
            o.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIncident incident = new AddIncident();
            incident.ShowDialog();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
           // AddUser user = new AddUser();
           // user.ShowDialog();
        }

        private void btn_Loginpage_Click(object sender, EventArgs e)
        {
            LoginPage.Instance.ShowDialog();
        }
    }
}
