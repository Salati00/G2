using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public interface IListable
    {
        List<object> ToList(IListable model);
        List<object> ToList();
    }
}
