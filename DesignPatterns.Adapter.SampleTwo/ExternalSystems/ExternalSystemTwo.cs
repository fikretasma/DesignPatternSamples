using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleTwo
{
    public class ExternalSystemTwo
    {
        public void Begin() {
            Console.WriteLine("external system two begin");
        }
        public void Terminate() {
            Console.WriteLine("external system two terminate");
        }
    }
}
