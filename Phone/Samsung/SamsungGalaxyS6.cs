using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Samsung
{
    public class SamsungGalaxyS6 : AbstractSamsung, ISensorScreen, ISHealth, IFlagman
    {
        public override string Name
        {
            get { return "Samsung Galaxy S6"; }
        }

        public void CheckWeight(int weight, int height)
        {
            var bodyIndex = height - 110;

            if (weight > bodyIndex)
            {
                Console.WriteLine("You should do some cardio!");
            }
            else
            {
                Console.WriteLine("You're fine");
            }
        }

        public void CountSteps()
        {
            Console.WriteLine("I am counting your steps");
        }

        public void InteractViaScreen()
        {
            Console.WriteLine("I am touch screen");
        }

        public void GalaxyAssist()
        {
            Console.WriteLine("My name is Galaxy, how can I help you?"); ;
        }

        public string Moto()
        {
            return "Samsung Flagman. Be the best";
        }
    }
}
