﻿using System;
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
        private object item;

        public Uc_TableRow(object _item)
        {
            InitializeComponent();
            item = _item;
        }

        public void Remove()
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
