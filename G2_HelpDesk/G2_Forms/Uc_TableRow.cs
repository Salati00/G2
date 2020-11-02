using System;
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

namespace G2_Forms
{
    public partial class Uc_TableRow : UserControl
    {
        private List<object> items;
        private int x, y;
        private const int DELTA_X = 120;
        private bool editable;

        /// <summary>
        /// Takes one object and interprets it as a list to populate the fields to be displayed
        /// </summary>
        /// <param name="Items">List of objects to be displayed</param>
        /// <param name="addEdit">Boolean that decides whether a button will be shown at the end of every item</param>
        public Uc_TableRow(List<object> Items, bool addEdit = false)
        {
            InitializeComponent();
            items = Items.ToList();
            x = 20; y = 20;
            editable = addEdit;
            CreateFields();
            this.AutoSize = true;
        }

        //Private Methods
        private void CreateFields()
        {
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
            if (editable)
            {
                Button b = new Button();
                b.Text = "Edit";
                b.Visible = true;
                b.Show();
                b.Top = y;
                b.Left = x;
                b.Click += B_Click;
                this.Controls.Add(b);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.ShowDialog();
        }

        //Public Methods
        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
