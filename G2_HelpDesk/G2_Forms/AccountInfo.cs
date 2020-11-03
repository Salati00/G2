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
using G2_Logic;

namespace G2_Forms
{
    public partial class AccountInfo : Form
    {
        Admin admin;
        Person person;
        EditUserLogic updateUser = new EditUserLogic();
        public AccountInfo(Admin admin,Person person)
        {
            InitializeComponent();
            this.admin = admin;
            this.person = person;
            
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            if(person == null)
            {
                PlaceAdmin(admin);
            }
            else if (admin == null)
            {
                HideAdminInfo();
                PlaceEmployee(person);
            }
        }

        public void PlaceEmployee(Person employee)
        {
            txt_firstname.Text = employee.Firstname;
            txt_lastname.Text = employee.Lastname;
            txt_email.Text = employee.Email;
            txt_phonenumber.Text = employee.PhoneNumber;
        }

        public void HideAdminInfo()
        {
            lbl_username.Visible = false;
            lbl_password.Visible = false;
            txt_username.Visible = false;
            txt_password.Visible = false;
        }

        private void PlaceAdmin(Admin admin)
        {
            txt_firstname.Text = admin.Firstname;
            txt_lastname.Text = admin.Lastname;
            txt_username.Text = admin.Username;
            txt_email.Text = admin.Email;
            txt_phonenumber.Text = admin.PhoneNumber;
            btn_Delete.Visible = false;

        }
        private void Btn_editAccount_Click(object sender, EventArgs e)
        {
            EnableTextBox();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                EditAdmin();
            }
            else if (admin == null)
            {
                editPerson();
            }
            DiasableTextBox();
            this.Close();

        }

        public void editPerson()
        {
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            string phonenumber = txt_phonenumber.Text;
            Person Newperson = new Person(person._id, firstname, lastname, phonenumber, email);

            updateUser.EditEmployee(Newperson);
        }

        public void EditAdmin()
        {
            string password;
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string username = txt_username.Text;
            if (String.IsNullOrEmpty(txt_password.Text))
            {
                password = null;
            }
            else
            {
                password = txt_password.Text;

            }
            string email = txt_email.Text;
            string phonenumber = txt_phonenumber.Text;
            Admin newAdmin = new Admin(admin._id, firstname, lastname,username,password, phonenumber, email);

            updateUser.EditAdmin(newAdmin);
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            updateUser.DeletePerson(person);
            this.Close();
        }
    }
}
