﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class RAMFactory : IFactory<RAMFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent<RAMFactory>, new()
        {
            Console.WriteLine("Creating RAM: " + typeof(TComponent));
            return new TComponent();
        }
    }
}