using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factory;
using Factory.Phone;
using Factory.Phone.Samsung;
using Factory.Phone.Apple;
using Factory.Phone.WindowsPhone;

namespace Factory
{
    public class ManufacturerChecker
    {
        IFlagman flagman;
        IBudgetModel budgModel;
        IPhoneFactory factory;
        Manufacturers manufacturer;

        public ManufacturerChecker(Manufacturers m)
        {
            manufacturer = m;
        }

        public void CheckProducts()
        {
            switch (manufacturer)
            {
                case Manufacturers.Apple:
                    factory = new AppleFactory();
                    break;
                case Manufacturers.Samsung:
                    factory = new SamsungFactory();
                    break;
                case Manufacturers.WindowsPhone:
                    factory = new WidowsPhoneFactory();
                    break;
            }

            Console.WriteLine(manufacturer.ToString() + ":\nFlagman's moto: " +
            factory.GetFlagman().Moto() + "\nBudget model's moto: " + factory.GetBudgetModel().Moto());
        }
    }

    public enum Manufacturers
    {
        Apple,
        Samsung,
        WindowsPhone
    }
}
