using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace G2_Forms
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            var database = client.GetDatabase("g2Database");
            var dbList = client.ListDatabases().ToList();
            int count = 0;
            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                count++;
            }
            lbl_itemCount.Text = count.ToString();
        }
    }
}
