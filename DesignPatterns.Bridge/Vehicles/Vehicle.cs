using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    abstract class Vehicle
    {
        IGear gear;
        public Vehicle(IGear gear)
        {
            this.gear = gear;
        }

        internal abstract void addGear();
    }
}
