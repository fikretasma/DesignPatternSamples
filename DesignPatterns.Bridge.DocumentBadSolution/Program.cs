using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            // one level abstraction
            List<IDocument> documents = new List<IDocument>();

            var faq = new FAQ
            {
                Title = "Test FAQ",
                Question = "What about this FAQ?"
            };
            documents.Add(faq);
            //faq.Print();


            var book = new BackwardBook
            {
                Author = "Dostoyevski",
                Title = "Suç ve Ceza"
            };
            documents.Add(book);

            //var book = new Book
            //{
            //    Author = "Dostoyevski",
            //    Title = "Suç ve Ceza"
            //};
            //documents.Add(book);
            //book.Print();

            var paper = new Paper
            {
                Title = "Just a paper",
                Footer = "Test footer",
                Header = "Test header"
            };
            documents.Add(paper);
            //paper.Print();


            foreach (var document in documents)
            {
                document.Print();
            }

            Console.ReadKey();
        }
    }
}
