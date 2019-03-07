using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IGear gear = new ManualGear();
            Vehicle vehicle = new Car(gear);
            vehicle.addGear();

            gear = new AutoGear();
            vehicle = new Car(gear);
            vehicle.addGear();

            gear = new ManualGear();
            vehicle = new Truck(gear);
            vehicle.addGear();

            gear = new AutoGear();
            vehicle = new Truck(gear);
            vehicle.addGear();
        }
    }
}
