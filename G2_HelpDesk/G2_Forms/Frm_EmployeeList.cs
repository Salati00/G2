using G2_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Logic;

namespace G2_Forms
{
    public partial class Frm_EmployeeList : Form
    {
        AdminLogic userDB;

        public Frm_EmployeeList()
        {
            InitializeComponent();
            userDB = new AdminLogic();
            Uc_Menu.Window = this;

            Uc_List.GetButton.Text = "Add Employee";
            Uc_List.GetButton.Show();
            Uc_List.GetButton.Click += GetButton_Click;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            AddUser usr = new AddUser();
            usr.ShowDialog();
        }


        private void EmployeeList_Load(object sender, EventArgs e)
        {
            List<string> Headers = new List<string>();
            Headers.Add("Name");
            Headers.Add("Surname");
            Headers.Add("Phone Number");
            Headers.Add("E-Mail");
            Headers.Add("UserName");
            Headers.Add("Password Hash");

            Uc_Menu.Window = this;
            Uc_List.SetHeaders(Headers);
            Uc_List.SetMode(typeof(Person));
            userDB.GetAllUsers().ForEach(x => Uc_List.AddElement(x.ToList()));
        }
    }
}
