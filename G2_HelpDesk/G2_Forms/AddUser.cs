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

        AdminLogic AddAdminLogic = new AdminLogic();

        private void PopulateCombobox()
        {
            cBoxType.Items.Add(UserType.Employee);
            cBoxType.Items.Add(UserType.Admin);

            cBoxBranch.Items.Add(Branch.Amsterdam);
            cBoxBranch.Items.Add(Branch.Denhagg);
            cBoxBranch.Items.Add(Branch.Eindhoven);
            cBoxBranch.Items.Add(Branch.Haarlem);
            cBoxBranch.Items.Add(Branch.Venlo);
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
                if(cBoxType.GetItemText(cBoxType.SelectedItem) == UserType.Admin.ToString())
                {
                    Admin newUser = new Admin(firstname, lastname, username, password, phonenumber, email);
                    AddAdminLogic.AddUser(newUser);
                }
                else
                {
                    Branch branch  = (Branch)cBoxBranch.SelectedValue;
                    Employee employee = new Employee(firstname, lastname, phonenumber,email, branch);

                }
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
