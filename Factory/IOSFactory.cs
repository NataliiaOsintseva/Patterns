using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.IOS;

namespace Factory.Factory
{
    public class IOSFactory : IPhoneFactory
    {
        public IPhoneBase CreatePhone()
        {
            return new IPhone5S();
        }
    }
}
