using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    public class Paper : IDocument
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public void Print()
        {
            Console.WriteLine("Title : {0}", Title);
            Console.WriteLine("Header : {0}", Header);
            Console.WriteLine("Footer : {0}", Footer);
            Console.WriteLine();

        }
    }
}
