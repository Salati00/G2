using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Forms
{
    public partial class Frm_DataList : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">0 = Ticket, 1 = User</param>
        public Frm_DataList(int type)
        {
            InitializeComponent();

            Uc_TableMain.SetMode(type);
        }
    }
}
