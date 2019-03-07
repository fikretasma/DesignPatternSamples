using ConfigLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectGoodVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int retryCount = ConfigHelper.GetValue<int>("retryCount");
        }
    }
}
