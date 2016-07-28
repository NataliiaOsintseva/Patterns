using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.Android;

namespace Factory.Factory
{
    public class AndroidFactory : IPhoneFactory
    {
        public IPhoneBase CreatePhone()
        {
            return new SamsungGalaxyS6();
        }

    }
}
