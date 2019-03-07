using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class ManualGear : IGear
    {
        public void HandleGear()
        {
            Console.WriteLine("Manual Gear");
        }
    }
}
