using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Forms
{
    public partial class FrmComponent_MenuBar : UserControl
    {
        private Form window;
        private Form target = null;


        public FrmComponent_MenuBar()
        {
            InitializeComponent();
        }

        public Form Window
        {
            get { return window; }
            set 
            {
                if(value != null)
                {
                    window = value;
                    window.FormClosed += Window_FormClosed;
                }
            }
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            window = target;
            if (target == null)
                target = Dashboard.GetInstance();
            target.Show();
        }

        private void Btn_Tickets_Click(object sender, EventArgs e)
        {
            target = new Frm_TicketList();
            window.Close();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            target = new Frm_EmployeeList();
            window.Close();
        }

        private void Btn_DashBoard_Click(object sender, EventArgs e)
        {
            target = Dashboard.GetInstance();
            window.Close();
        }
    }
}
