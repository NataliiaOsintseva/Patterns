﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.ComponentsWarehouse.Manipulator
{
    abstract class AbstractManipulator : IComponent
    {
        public abstract void Interact(AbstractMotherBoard motherboard);

        public virtual void Operate()
        {
            Console.WriteLine(this + "  is up and running!");
        }
    }
}
