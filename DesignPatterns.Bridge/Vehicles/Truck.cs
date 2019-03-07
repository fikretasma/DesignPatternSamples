using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    internal class Truck : Vehicle
    {
        IGear gear;
        public Truck(IGear gear): base(gear)
        {
            this.gear = gear;
        }

        internal override void addGear()
        {
            Console.WriteLine("Truck handles");
            gear.HandleGear();
        }
    }
}
