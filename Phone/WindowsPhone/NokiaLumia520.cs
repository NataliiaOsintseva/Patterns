using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.WindowsPhone
{
    public class NokiaLumia520 : AbstractWindowsPhone, IFlagman
    {
        public override string Name
        {
            get { return "Nokia Lumia 520"; }
        }

        public string Moto()
        {
            return "Nokia is new flagman";
        }
    }
}
