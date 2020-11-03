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
        PersonLogic user = new PersonLogic();

        private static readonly Lazy<LoginPage> lazyInstance = new Lazy<LoginPage>(() => new LoginPage());

        public static LoginPage Instance { get { return lazyInstance.Value; } }

        private LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            Admin UserLogin = user.LoginUser(username, password);

            if(UserLogin == null)
            {
                lbl_incorectLogin.Visible = true;
            }
            else
            {
                lbl_incorectLogin.Visible = false;
                Dashboard.GetInstance(UserLogin).Show();
                this.Hide();
            }
        }

        public void Clear()
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}
