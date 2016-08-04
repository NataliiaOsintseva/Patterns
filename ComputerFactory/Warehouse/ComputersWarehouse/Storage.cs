using ComputerFactory.Warehouse.Factory.ComputersFactory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.ComputersWarehouse
{
    class Storage
    {
        string computerName;
        int storageCapacity = 10;

        AbstractComputerFactory factory;

        ArrayList storedDell = new ArrayList();
        ArrayList storedAsus = new ArrayList();

        Dictionary<string, AbstractComputerFactory> factoryDefiner = new Dictionary<string, AbstractComputerFactory>();
        Dictionary<string, ArrayList> storageDefiner = new Dictionary<string, ArrayList>();

        public Storage()
        {
            FillStorageDictionary();
            FillFactoryDictionary();
        }

        public IComputer GetSpecificComputer(string name)
        {
            this.computerName = name;
            ArrayList selectedComputers = SelectStorage();

            Console.WriteLine("Now I should check if there's enough items in a storage...");
            CheckShipProducts(selectedComputers);

            return BringComputerFromStorage(selectedComputers);
        }

        private void FillFactoryDictionary()
        {
            factoryDefiner.Add("dell", new DellComputerFactory());
            factoryDefiner.Add("asus", new AsusComputerFactory());
        }

        private void FillStorageDictionary()
        {
            storageDefiner.Add("dell", storedDell);
            storageDefiner.Add("asus", storedAsus);
        }

        private int StorageShortage(ArrayList arr) {
            return storageCapacity - arr.Count;
        }

        private void CheckShipProducts(ArrayList arr) {
            int shortage = StorageShortage(arr);
            if (shortage <= 5) {
                Console.WriteLine("We will bring you one in a minute..." );
                return;
            }

            Console.WriteLine("Looks like we are running out of computers.\nLet's ask Factory to produce some.");

            this.factory = SelectFactory();
            while (shortage > 0)
            {
                arr.Add(factory.GetComputer());
                shortage--;
            }

        }

        private IComputer BringComputerFromStorage(ArrayList arr)
        {
            Console.WriteLine("Your order {0} is being delivered...\n", arr[arr.Count - 1].GetType());
            return (IComputer)arr[arr.Count - 1];
        }

        private AbstractComputerFactory SelectFactory()
        {            
            if (factoryDefiner.ContainsKey(computerName))
            {
                return factoryDefiner[computerName];
            }
            return factoryDefiner["asus"];
        }

        private ArrayList SelectStorage() {
            if (storageDefiner.ContainsKey(computerName))
            {
                return storageDefiner[computerName];
            }

            Console.WriteLine("There is no such computer name, you'll get Asus by default...");
            return storageDefiner["asus"];
        }
    }
}
