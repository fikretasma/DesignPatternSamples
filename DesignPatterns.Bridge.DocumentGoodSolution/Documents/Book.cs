using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    public class Book : Document
    {
        public Book(IFormatter formatter):base(formatter)
        {

        }

        public string Title { get; set; }
        public string Author { get; set; }

        override public void Print()
        {
            Console.WriteLine(Formatter.Format("Title", Title));
            Console.WriteLine(Formatter.Format("Author", Author));
            Console.WriteLine();

        }
    }
}
