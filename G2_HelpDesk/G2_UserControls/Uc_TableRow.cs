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

namespace G2_UserControls
{
    public partial class Uc_TableRow : UserControl
    {
        private List<object> items;
        private int x, y;
        private const int DELTA_X = 120;

        /// <summary>
        /// Takes one object and interprets it as a list to populate the fields to be displayed
        /// </summary>
        /// <param name="Items">List of objects to be displayed</param>
        public Uc_TableRow(object Items)
        {
            InitializeComponent();
            items = (List<object>)Items;
            x = 20; y = 20;
            CreateFields();
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
            /*Button BtnRemove = new Button();
            BtnRemove.Top = y;
            BtnRemove.Left = x;
            BtnRemove.Text = "X";
            BtnRemove.Height = 30;
            BtnRemove.Width = 30;
            BtnRemove.Show();
            BtnRemove.Click += RemoveClick;
            this.Controls.Add(BtnRemove);*/
        }
        /*
        private void RemoveClick(object sender, EventArgs e)
        {

        }
        */
        //Public Methods
        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
