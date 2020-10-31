using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using G2_Model;

namespace G2_Forms
{
    public partial class AccountInfo : Form
    {
        Admin admin;
        public AccountInfo(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            txt_firstname.Text = admin.Firstname;
            txt_lastname.Text = admin.Lastname;
            txt_username.Text = admin.Username;
            txt_password.Text = admin.Password;
            txt_email.Text = admin.Email;
            txt_phonenumber.Text = admin.PhoneNumber;
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(admin);
            dashboard.ShowDialog();
            this.Close();
        }

        private void Btn_editAccount_Click(object sender, EventArgs e)
        {
            EnableTextBox();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            //Edit user using dao
            DiasableTextBox();
        }

        private void DiasableTextBox()
        {
            txt_firstname.ReadOnly = true;
            txt_lastname.ReadOnly = true;
            txt_username.ReadOnly = true;
            txt_password.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_phonenumber.ReadOnly = true;
        }

        private void EnableTextBox()
        {
            txt_firstname.ReadOnly = false;
            txt_lastname.ReadOnly = false;
            txt_username.ReadOnly = false;
            txt_password.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_phonenumber.ReadOnly = false;
        }
    }
}
