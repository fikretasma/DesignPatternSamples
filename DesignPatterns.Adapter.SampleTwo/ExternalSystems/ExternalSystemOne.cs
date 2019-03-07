using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleTwo
{
    public class ExternalSystemOne
    {
        public void Start() {
            Console.WriteLine("external system one start");
        }
        public void End() {
            Console.WriteLine("external system one end");
        }
    }
}
