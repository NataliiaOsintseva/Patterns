﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.Factory.ComponentsFactory
{
    public class DisplayFactory : IComponentFactory<DisplayFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent, new()
        {
            Console.WriteLine("Creating Display: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
