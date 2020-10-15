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


namespace G2_Forms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        LogicTest AddUserLogic = new LogicTest();

        private void CreateNewUser_btn_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string username = txt_lastname.Text;
            string password = txt_password.Text;
            string repeatPasss = txt_repeatPassword.Text;
            int phonenumber = int.Parse(txt_phoneNumber.Text);
            string email = txt_email.Text;

            if(password != repeatPasss)
            {
                MessageBox.Show("Make sure passowrd is the same.");
            }
            else
            {
                User newUser = new User(firstname, lastname, username, password, phonenumber, email);
                
                AddUserLogic.AddUser(newUser);
            }
              
        }
    }
}
