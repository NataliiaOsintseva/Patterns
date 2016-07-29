using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factory;
using Factory.Phone;
using Factory.Phone.Samsung;
using System.Reflection;

namespace Factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            ManufacturerChecker checker = new ManufacturerChecker(Manufacturers.Samsung);
            checker.CheckProducts();

            checker = new ManufacturerChecker(Manufacturers.WindowsPhone);
            checker.CheckProducts();

            checker = new ManufacturerChecker(Manufacturers.Apple);
            checker.CheckProducts();

            Console.ReadKey();             
        }
    }
}
