﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using G2_Model;
using MongoDB.Driver.Core.Authentication;

namespace G2_Forms
{
    public partial class Uc_TableRow : UserControl
    {
        private IListable item;
        private int x, y;
        private const int DELTA_X = 120;
        private int editable;

        /// <summary>
        /// Takes one object and interprets it as a list to populate the fields to be displayed
        /// </summary>
        /// <param name="Items">List of objects to be displayed</param>
        /// <param name="addEdit">Boolean that decides whether a button will be shown at the end of every item</param>
        public Uc_TableRow(IListable _item, int addEdit = 0)
        {
            InitializeComponent();
            item = _item;
            x = 20; y = 20;
            editable = addEdit;
            CreateFields();
            this.AutoSize = true;
        }

        //Private Methods
        private void CreateFields()
        {
            List<object> items = item.ToList();
            for (int i = 0; i < items.Count(); i++)
            {
                Label l = new Label();
                l.Text = items[i].ToString();
                l.Visible = true;
                l.Show();
                l.Top = y;
                l.Left = x;
                this.Controls.Add(l);

                x += DELTA_X;
            }
            Person PersonObject = this.item as Person;
            if(PersonObject != null)
            {
                G2_Logic.PersonLogic logic = new G2_Logic.PersonLogic();
                Label l = new Label();
                l.Text = logic.GetAmountOfTickets(PersonObject).ToString();
                l.Visible = true;
                l.Show();
                l.Top = y;
                l.Left = x;
                this.Controls.Add(l);
            }
            else
            {
                Ticket TicketObject = this.item as Ticket;
                if(TicketObject != null)
                {
                    Label l = new Label();
                    l.Text = TicketObject.User.GetFullName();
                    l.Visible = true;
                    l.Show();
                    l.Top = y;
                    l.Left = x;
                    this.Controls.Add(l);
                }
            }

            if (editable == 1)
            {
                x += DELTA_X;
                Button b = new Button();
                b.Text = "Edit";
                b.Visible = true;
                b.Show();
                b.Top = y;
                b.Left = x;
                b.Click += B_User_Click;
                this.Controls.Add(b);
            }
            else if (editable == 2)
            {
                x += DELTA_X;
                Button b = new Button();
                b.Text = "Transfer";
                b.Visible = true;
                b.Show();
                b.Top = y;
                b.Left = x;
                b.Click += B_Ticket_Click;
                this.Controls.Add(b);

                x += DELTA_X;
                Button btn_EditTicket = new Button();
                btn_EditTicket.Text = "Edit";
                btn_EditTicket.Visible = true;
                btn_EditTicket.Show();
                btn_EditTicket.Top = y;
                btn_EditTicket.Left = x;
                btn_EditTicket.Click += Btn_EditTicket_Click; ;
                this.Controls.Add(btn_EditTicket);
            }
        }

        private void Btn_EditTicket_Click(object sender, EventArgs e)
        {
            Edit_Incident editIncident = new Edit_Incident((Ticket)item);
            editIncident.ShowDialog();
            ((Uc_Table)this.Parent).UpdateTable();

        }

        private void B_Ticket_Click(object sender, EventArgs e)
        {
            Frm_TransferTicket transferForm = new Frm_TransferTicket((Ticket)item);
            transferForm.ShowDialog();
            ((Uc_Table)this.Parent).UpdateTable();
        }

        private void B_User_Click(object sender, EventArgs e)
        {
            Person person = (Person)item;

            AccountInfo account = new AccountInfo(null, person);
            account.ShowDialog();
        }

        //Public Methods
        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
