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
using G2_Logic;
using System.Security.Permissions;

namespace G2_Forms
{
    public partial class AddUser : Form
    {
        public AddUser(Admin admin)
        {
            InitializeComponent();
            PopulateCombobox();

        }

        UserLogic AddUserLogic = new UserLogic();

        private void PopulateCombobox()
        {
            cBoxType.Items.Add(UserType.Employee);
            cBoxType.Items.Add(UserType.Admin);
        }

        private void CreateNewUser_btn_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string username = txt_lastname.Text;
            string password = txt_password.Text;
            string repeatPasss = txt_repeatPassword.Text;
            string phonenumber = txt_phoneNumber.Text;
            string email = txt_email.Text;

            if(password != repeatPasss)
            {
                MessageBox.Show("Make sure passowrd is the same.");
            }
            else
            {
                Admin newUser = new Admin(firstname, lastname, username, password, phonenumber, email);
                
                AddUserLogic.AddUser(newUser);
            }
              
        }



        private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxType.GetItemText(cBoxType.SelectedItem) == UserType.Admin.ToString())
            {
                txt_username.Show();
                txt_password.Show();
                lblUsername.Show();
                lblPassword.Show();
                txt_repeatPassword.Show();
                lblRepeatPassword.Show();
                
            }
            else
            {
                txt_username.Hide();
                txt_password.Hide();
                lblUsername.Hide();
                lblPassword.Hide();
                txt_repeatPassword.Hide();
                lblRepeatPassword.Hide();
            }
        }
    }
}
