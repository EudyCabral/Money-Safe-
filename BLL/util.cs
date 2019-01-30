using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class util
    {
        public static int Toint(string numero)
        {
            int n = 0;
            int.TryParse(numero, out n);
            return n;
        }
    }
}
