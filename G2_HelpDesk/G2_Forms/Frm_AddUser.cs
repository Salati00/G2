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
        public AddUser()
        {
            InitializeComponent();
            PopulateCombobox();

        }

        PersonLogic AddAdminLogic = new PersonLogic();

        private void PopulateCombobox()
        {
            cBoxType.DataSource = Enum.GetValues(typeof(UserType));

            cBoxBranch.DataSource = Enum.GetValues(typeof(Branch));

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

            if(firstname == "" || lastname == "" || phonenumber == "" || email == "")
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                if (password != repeatPasss)
                {
                    MessageBox.Show("Make sure password is the same.");
                }
                else
                {
                    if (cBoxType.GetItemText(cBoxType.SelectedItem) == UserType.Admin.ToString())
                    {
                        if(username == "" || password == "" || repeatPasss == "")
                        {
                            MessageBox.Show("All admins need username and password");
                        }
                        else
                        {
                            Admin newUser = new Admin(firstname, lastname, username, password, phonenumber, email);
                            AddAdminLogic.AddAdmin(newUser);
                            this.Close();
                        }
                    }
                    else
                    {
                        Branch branch = (Branch)cBoxBranch.SelectedItem;
                        Employee employee = new Employee(firstname, lastname, phonenumber, email, branch);
                        AddAdminLogic.AddEmployee(employee);
                        this.Close();
                    }
                }
            }
        }

            

        private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxType.GetItemText(cBoxType.SelectedItem) == UserType.Admin.ToString())
            {
                ShowInfo();
            }
            else
            {
                HideInfo();
            }
            
        }
        private void HideInfo()
        {
            txt_username.Hide();
            txt_password.Hide();
            lblUsername.Hide();
            lblPassword.Hide();
            txt_repeatPassword.Hide();
            lblRepeatPassword.Hide();
        }
        private void ShowInfo()
        {
            txt_username.Show();
            txt_password.Show();
            lblUsername.Show();
            lblPassword.Show();
            txt_repeatPassword.Show();
            lblRepeatPassword.Show();
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard.GetInstance().Show();
            this.Close();
        }
    }
}
