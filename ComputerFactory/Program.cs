using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse;
using ComputerFactory.Warehouse.Factory.ComputersFactory;
using ComputerFactory.Warehouse.ComputersWarehouse;

namespace ComputerFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesOffice sales = new SalesOffice();
            sales.SellComputer();

            sales.SellComputer();
            Console.ReadKey();
        }
    }
}
