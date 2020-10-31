﻿using System;
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
    public partial class Dashboard : Form
    {
        Admin admin;
        public Dashboard(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            lbl_Username.Text = admin.Firstname + " " + admin.Lastname;
        }


        private void btb_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage Logout = new LoginPage();
            Logout.ShowDialog();
            this.Close();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser newUser = new AddUser(admin);
            newUser.ShowDialog();
            this.Close();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo account = new AccountInfo(admin);
            account.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket ticket = new Ticket();
            ticket.ShowDialog();
            this.Hide();
        }

        private void btb_EmployeeList_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeList employees = new EmployeeList(admin);
            employees.ShowDialog();
            this.Close();
        }
    }
}
