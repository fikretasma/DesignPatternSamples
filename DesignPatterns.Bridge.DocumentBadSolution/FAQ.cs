using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    class FAQ : IDocument
    {
        public string Title { get; set; }
        public string Question { get; set; }

        public void Print()
        {
            Console.WriteLine("Title : {0}", Title);
            Console.WriteLine("Question : {0}", Question);
            Console.WriteLine();

        }
    }
}
