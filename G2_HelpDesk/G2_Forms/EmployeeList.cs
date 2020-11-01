using G2_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_DAL;
using G2_UserControls;

namespace G2_Forms
{
    public partial class EmployeeList : Form
    {
        UserDAO userDB;

        public EmployeeList(Admin admin)
        {
            InitializeComponent();
            userDB = new UserDAO();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            List<string> Headers = new List<string>();

            //UC_employeeList = new Uc_Table();
            userDB.DbGetAllUsers().ForEach(x => {
                UC_employeeList.AddElement(x.ToList());
                }
            );
        }
    }
}
