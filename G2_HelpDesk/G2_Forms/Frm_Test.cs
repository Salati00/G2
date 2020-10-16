using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using MongoDB.Driver;
using G2_UserControls;
using G2_Model;

namespace G2_Forms
{
    public partial class Frm_Test : Form
    {
        public Frm_Test()
        {
            InitializeComponent();
        }

        private void Btn_AddRow_Click(object sender, EventArgs e)
        {
            UcTab_Main.AddElement((new User("Giorgio","Salati","salati00","password","+393454455410","salati00.giorgio@gmail.com")).ToList());
        }

        private void Frm_Test_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            var database = client.GetDatabase("g2Database");
            var dbList = client.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                MessageBox.Show(db.ToString());
            }
        }

        private void UcTab_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
