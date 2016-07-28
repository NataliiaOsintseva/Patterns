using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.WindowsPhone;

namespace Factory.Factory
{
    public class WidowsPhoneFactory : IPhoneFactory
    {
        public IPhoneBase CreatePhone()
        {
            return new NokiaLumia520();
        }
    }
}
