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
    public partial class AccountInfo : Form
    {
        User admin;
        public AccountInfo(User admin)
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


    }
}
