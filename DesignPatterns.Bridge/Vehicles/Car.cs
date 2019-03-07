using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    internal class Car : Vehicle
    {
        IGear gear;
        public Car(IGear gear): base(gear)
        {
            this.gear = gear;
        }

        internal override void addGear()
        {
            Console.WriteLine("Car handles");
            gear.HandleGear();
        }
    }
}
