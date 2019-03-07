using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    class FAQ : Document
    {
        public FAQ(IFormatter formatter): base(formatter)
        {

        }

        public string Title { get; set; }
        public string Question { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Title", Title));
            Console.WriteLine(Formatter.Format("Question", Question));
            Console.WriteLine();

        }
    }
}
