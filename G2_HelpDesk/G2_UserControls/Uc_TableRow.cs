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
        public Uc_TableRow(List<object> Items)
        {
            InitializeComponent();
            items = Items.ToList();
            x = 20; y = 20;
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
        }

        //Public Methods
        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
