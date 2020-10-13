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
        private int x = 30;
        private int y = 70 ;
        private const int DELTA_Y = 35;

        private const int H_Y = 50;
        private int H_X = 50;
        private const int H_DELTA_X = 120;

        private List<object> elementList;
        /// <summary>
        /// Takes list of strings as headers for the table to be displayed
        /// </summary>
        /// <param name="Headers">List of strings to be displayed as headers</param>
        public Uc_Table(List<string> Headers)
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.elementList = new List<object>();

            CreateFields(Headers);
        }
        /// <summary>
        /// FOR TESTING PURPOSES
        /// </summary>
        public Uc_Table()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.elementList = new List<object>();

            CreateFields(null);
        }

        //Private methods
        private void CreateFields(List<string> Headers)
        {
            if(Headers == null)
            {
                Headers = new List<string>();
                Headers.Add("ID");
                Headers.Add("Subject");
                Headers.Add("User");
                Headers.Add("Date");
                Headers.Add("Status");
            }
            for (int i = 0; i < Headers.Count(); i++)
            {
                Label l = new Label();
                l.Text = Headers[i];
                l.Visible = true;
                l.Show();
                l.Top = H_Y;
                l.Left = H_X;
                this.Controls.Add(l);

                H_X += H_DELTA_X;
            }
        }
        
        private void AddRow(List<object> item)
        {
            if(item.Count == 0)
            {
                item.Add("ID");
                item.Add("Subject");
                item.Add("User");
                item.Add("Date");
                item.Add("Status");
            }

            Uc_TableRow r = new Uc_TableRow(item);
            r.Top = y;
            r.Left = x;

            this.Controls.Add(r);

            y += DELTA_Y;
        }

        //Public methods
        /// <summary>
        /// Adds one entry to the table
        /// </summary>
        /// <param name="item">List of objects to be displayed in table as entries</param>
        public void AddElement(List<object> item)
        {
            elementList.Add(item);
            AddRow((List<object>)elementList.Last<object>());
        }
        /// <summary>
        /// Forces Update of displayed elements
        /// </summary>
        public void UpdateTable()
        {
            this.Controls.OfType<Uc_TableRow>().ToList().ForEach(x => { x.Remove(); });
            y = 50;
            x = 50;

            foreach (var item in elementList)
            {
                AddRow((List<object>)item);
            }
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

        private void Btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
