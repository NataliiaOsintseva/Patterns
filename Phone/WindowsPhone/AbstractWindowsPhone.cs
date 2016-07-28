using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.WindowsPhone
{
    class AbstractWindowsPhone : PhoneBase
    {
        public override string OperationalSystem
        {
            get { return "Windows is my OS"; }
        }
    }
}
