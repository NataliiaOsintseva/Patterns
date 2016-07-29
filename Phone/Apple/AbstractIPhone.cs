using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Apple
{
    public abstract class AbstractIPhone : PhoneBase, ICamera, ISensorScreen, ISiri
    {
        public override string OperationalSystem
        {
            get { return "My os is iOS! I'm Apple-phone"; }
        }

        public void Assist()
        {
            Console.WriteLine("My name is Siri, may I help you?"); ;
        }

        public void Flash()
        {
            Console.WriteLine("Let the light come here!");
        }

        public void InteractViaScreen()
        {
            Console.WriteLine("I am touch screen");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Let's take selfies!");
        }
    }
}
