using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_UserControls
{
    public partial class Uc_TableRow : UserControl
    {
        private List<object> items;
        private int x, y;
        private const int DELTA_X = 120;

        public Uc_TableRow(object Items)
        {
            InitializeComponent();
            items = (List<object>)Items;
            x = 20; y = 20;
            CreateFields();
        }

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

        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
