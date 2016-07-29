using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.WindowsPhone
{
    public class NokiaLumia300 : AbstractWindowsPhone, IBudgetModel
    {
        public string Moto()
        {
            return "Not fansy, but reliable";
        }
    }
}
