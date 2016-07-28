using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone
{
    public abstract class PhoneBase : IPhoneBase
    {
        private string name = "Simple old-fashioned phone";

        public virtual string Name { get; }
        public abstract string OperationalSystem { get; }

        public void Ring()
        {
            Console.WriteLine("I am ringing! Pick up the phone!");
        }

        public void Call()
        {
            Console.WriteLine("Calling your friend...");
        }

        public void TurnOff()
        {
            Console.WriteLine(Name + " is turned off\n");
        }

        public void TurnOn()
        {
            Console.WriteLine( Name + " is turned on and ready to ring!");
        }
    }
}
