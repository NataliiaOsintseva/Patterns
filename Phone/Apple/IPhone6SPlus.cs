using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Apple
{
    public class IPhone6SPlus : AbstractIPhone, IFlagman
    {
        public string Moto()
        {
            return "iPhone 6S Plus A6. All of your friends will be envy.";
        }
    }
}
