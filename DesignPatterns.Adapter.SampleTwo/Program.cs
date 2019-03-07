using DesignPatterns.Adapter.SampleTwo.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            IExternalSystemAdapter externalSystemAdapterOne = new ExternalSystemOneAdapter();
            externalSystemAdapterOne.Open();
            externalSystemAdapterOne.Close();

            IExternalSystemAdapter externalSystemAdapterTwo = new ExternalSystemTwoAdapter();
            externalSystemAdapterTwo.Open();
            externalSystemAdapterTwo.Close();
        }
    }
}
