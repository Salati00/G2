using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;
using G2_Model;


namespace G2_Logic
{
    public class EditUserLogic
    {
        EditUserDAO editEmployee = new EditUserDAO();

        public void EditEmployee(Person person)
        {
            editEmployee.DbUpdateEmployee(person);
        }
        public void EditAdmin(Admin admin)
        {
            editEmployee.DbUpdateAdmin(admin);
        }
        public void DeletePerson(Person person)
        {
            editEmployee.DeletePerson(person);
        }
    }
}
