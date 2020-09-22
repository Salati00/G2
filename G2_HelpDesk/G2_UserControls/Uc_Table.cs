using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
using System.Runtime.CompilerServices;

namespace G2_UserControls
{
    public partial class Uc_Table : UserControl
    {
        private int x = 50;
        private int y = 50;


        private List<object> elementList;

        public Uc_Table()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.elementList = new List<object>();
        }

        
        //Private methods
        public void UpdateTable()
        {
            this.Controls.OfType<Uc_TableRow>().ToList().ForEach(x => { x.Remove(); });
            y = 50;
            x = 50;

            foreach (var item in elementList)
            {
                AddRow(item);
            }
        }

        private void AddRow(object item)
        {
            Uc_TableRow r = new Uc_TableRow(item);
            r.Top = y;
            r.Left = x;

            this.Controls.Add(r);

            y += 35;
        }

        //Public methods
        public void AddElement(object item)
        {
            elementList.Add(item);
            AddRow(elementList.Last<object>());
        }


        //Events
        private void Txt_Filter_TextChanged(object sender, EventArgs e)
        {
            Tmr_Filter.Enabled = false;
            Tmr_Filter.Stop();


            Tmr_Filter.Enabled = true;
            Tmr_Filter.Start();
        }


        private void Tmr_Filter_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            ((Timer)sender).Enabled = false;
            

            MessageBox.Show("Retrieve data again");
            this.UpdateTable();
        }
    }
}
