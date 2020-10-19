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
using G2_Model;

namespace G2_Forms
{
    public partial class LoginPage : Form
    {
        UserLogic user = new UserLogic();

        public LoginPage()
        {
            InitializeComponent();
        }


        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            User UserLogin = user.LoginUser(username, password);

            if(UserLogin == null)
            {
                lbl_incorectLogin.Visible = true;
            }
            else
            {
                lbl_incorectLogin.Visible = false;
                this.Hide();
                Dashboard LoginSucsess = new Dashboard(UserLogin);
                LoginSucsess.ShowDialog();
                this.Close();

            }
        }
    }
}
