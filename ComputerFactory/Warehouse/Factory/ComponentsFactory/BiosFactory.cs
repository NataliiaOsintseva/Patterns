﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.Factory.ComponentsFactory
{
    public class BiosFactory : IComponentFactory<BiosFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent, new()
        {
            Console.WriteLine("Creating BIOS: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
