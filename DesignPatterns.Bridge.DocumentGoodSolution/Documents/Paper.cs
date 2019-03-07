using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    public class Paper : Document
    {
        public Paper(IFormatter formatter):base(formatter)
        {

        }

        public string Title { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Title", Title));
            Console.WriteLine(Formatter.Format("Header", Header));
            Console.WriteLine(Formatter.Format("Footer", Footer));
            Console.WriteLine();

        }
    }
}
