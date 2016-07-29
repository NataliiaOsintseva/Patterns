using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Samsung
{
    public class SamsungGalaxyA6 : AbstractSamsung, ISensorScreen, IBudgetModel
    {
        public void InteractViaScreen()
        {
            Console.WriteLine("I am touch screen");
        }

        public string Moto()
        {
            return "Samsung A6. Affordable and powerfull";
        }
    }
}
