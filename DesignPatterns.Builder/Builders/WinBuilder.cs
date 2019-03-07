using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    class WinBuilder : BuilderBase
    {
        protected override void BuildFooter()
        {
            Console.WriteLine("win footer");
        }

        protected override void BuildForms()
        {
            Console.WriteLine("win form");
        }

        protected override void BuildHeader()
        {
            Console.WriteLine("win header");
        }

        protected override void BuildMenu()
        {
            Console.WriteLine("win menu");
        }
    }
}
