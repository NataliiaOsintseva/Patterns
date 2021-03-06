﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.Factory.ComponentsFactory
{
    public class RAMFactory : IComponentFactory<RAMFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent, new()
        {
            Console.WriteLine("Creating RAM: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
