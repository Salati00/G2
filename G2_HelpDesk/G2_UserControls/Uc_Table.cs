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
    public partial class Uc_Table : UserControl
    {
        private int x = 50;
        private int y = 50;

        public Uc_Table()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void AddRow(object item)
        {
            Uc_TableRow r = new Uc_TableRow();
            r.Top = y;
            r.Left = x;

            this.Controls.Add(r);

            y += 35;
        }
    }
}
