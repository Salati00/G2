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
        Employee employee;
        public AccountInfo(Admin admin,Employee employee)
        {
            InitializeComponent();
            this.admin = admin;
            this.employee = employee;
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            if(employee == null)
            {
                txt_firstname.Text = admin.Firstname;
                txt_lastname.Text = admin.Lastname;
                txt_username.Text = admin.Username;
                txt_password.Text = admin.Password;
                txt_email.Text = admin.Email;
                txt_phonenumber.Text = admin.PhoneNumber;
            }
            else if (admin == null)
            {
                lbl_username.Visible = false;
                lbl_password.Visible = false;
                txt_username.Visible = false;
                txt_password.Visible = false;
            }
            
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

        private void AccountInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.GetInstance().Show();
        }
    }
}
