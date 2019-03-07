using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class WebBuilder : BuilderBase
    {
        protected override void BuildFooter()
        {
            Console.WriteLine("Web footer");
        }

        protected override void BuildForms()
        {
            Console.WriteLine("Web form");
        }

        protected override void BuildHeader()
        {
            Console.WriteLine("Web header");
        }

        protected override void BuildMenu()
        {
            Console.WriteLine("Web menu");
        }
    }
}
