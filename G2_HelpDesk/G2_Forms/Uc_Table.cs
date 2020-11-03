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
using G2_Model;
using G2_Logic;

namespace G2_Forms
{
    public partial class Uc_Table : UserControl
    {
        private int x = 5;
        private int y = 70 ;
        private const int DELTA_Y = 35;

        private const int H_Y = 50;
        private const int H_X = 5;
        private const int H_DELTA_X = 120;

        private List<object> elementList;
        private Type type;

        public Button GetButton { get => Btn_Add; }

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
            SetHeaders(Headers);
            this.AutoSize = true;
        }
        /// <summary>
        /// FOR TESTING PURPOSES
        /// </summary>
        public Uc_Table(Type type = null)
        {
            this.type = type;

            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.elementList = new List<object>();

            //SetHeaders(null);
        }

        public Uc_Table()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.elementList = new List<object>();
        }

        //Private methods
        private void AddRow(IListable item)
        {
            Uc_TableRow r;
            if(type == typeof(Person))
            {
                r = new Uc_TableRow(item, true);
            }
            else
            {
                r = new Uc_TableRow(item);
            }
            r.Top = y;
            r.Left = x;

            
            this.Controls.Add(r);

            y += DELTA_Y;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Public methods
        /// <summary>
        /// Adds one entry to the table
        /// </summary>
        /// <param name="item">List of objects to be displayed in table as entries</param>
        public void AddElement(IListable item)
        {
            elementList.Add(item);
            AddRow((IListable)elementList.Last());
        }
        /// <summary>
        /// Forces Update of displayed elements
        /// </summary>
        public void UpdateTable()
        {
            this.Controls.OfType<Uc_TableRow>().ToList().ForEach(x => { x.Remove(); });
            y = 70;
            x = 5;

            List<object> shownElements = elementList;
            if(this.type == typeof(Ticket) && Chk_Sort.Checked)
            {
                SortingTicketFunctionalityLogic.SortTickets(shownElements);
            }
            foreach (var item in shownElements)
            {
                if(this.type == typeof(Person))
                {
                    Txt_Filter.Show();
                    if (Txt_Filter.Text == "" || ((List<object>)item)[3].ToString().Contains(Txt_Filter.Text))
                        AddRow((IListable)item);
                }
                else if(this.type == typeof(Ticket))
                {
                    Txt_Filter.Hide();
                    AddRow((IListable)item);
                }
            }
        }

        public void SetHeaders(List<string> Headers)
        {
            if (Headers == null)
            {
                Headers = new List<string>();
                Headers.Add("ID");
                Headers.Add("Subject");
                Headers.Add("User");
                Headers.Add("Date");
                Headers.Add("Status");
            }
            int newX = H_X;
            for (int i = 0; i < Headers.Count(); i++)
            {
                Label l = new Label();
                l.Text = Headers[i];
                l.Visible = true;
                l.Show();
                l.Top = H_Y;
                l.Left = newX;
                this.Controls.Add(l);

                newX += H_DELTA_X;
            }
        }

        public void SetMode(Type type)
        {
            this.type = type;
            if (this.type == typeof(Person))
            {
                Txt_Filter.Show();
                Chk_Sort.Hide();
            }
            else if (this.type == typeof(Ticket))
            {
                Txt_Filter.Hide();
                Chk_Sort.Show();
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
            

            //MessageBox.Show("Retrieve data again");
            this.UpdateTable();
        }

        private void Chk_Sort_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateTable();
        }
    }
}
