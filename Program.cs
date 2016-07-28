using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factory;
using Factory.Phone;
using System.Reflection;

namespace Factory
{
    class Program
    {
        public static void Main(string[] args)
        {

            IPhoneFactory phoneFactory = LoadFactory();
            IPhoneBase phone = phoneFactory.CreatePhone();

            phone.Ring();
            phone.TurnOn();

        }

        static IPhoneFactory LoadFactory()
        {
            return new AndroidFactory();

        }
    }
}
