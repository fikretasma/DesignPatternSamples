using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    public class Book : IDocument
    {
        public string Title { get; set; }
        public string Author { get; set; }

        virtual public void Print()
        {
            Console.WriteLine("Title : {0}", Title);
            Console.WriteLine("Author : {0}", Author);
            Console.WriteLine();

        }
    }
}
