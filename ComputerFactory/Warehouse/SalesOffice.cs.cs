using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse.Factory.ComputersFactory;
using ComputerFactory.Warehouse.ComputersWarehouse;

namespace ComputerFactory.Warehouse
{
    // Client class 
    class SalesOffice
    {
        Storage storage = new Storage();

        public IComputer SellComputer()
        {
            Console.WriteLine("We have Asus and Dell computers, which one you would like to buy?\n");
            string computerName = Console.ReadLine().ToLower();

            Console.WriteLine("Let's see if we have such supplier! I should call manager from Storage Department!");

            IComputer commodity = storage.GetSpecificComputer(computerName);
            Console.WriteLine("\nYou can get your computer! \n 1000 $, please.");
            return commodity;
        }

    }
}
