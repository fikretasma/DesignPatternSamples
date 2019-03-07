using DesignPatterns.Bridge.DocumentBadSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentGoodSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // one level abstraction
            List<Document> documents = new List<Document>();
            IFormatter formatter = new LogFormatter();

            var faq = new FAQ(formatter)
            {
                Title = "Test FAQ",
                Question = "What about this FAQ?"
            };
            documents.Add(faq);
            //faq.Print();


            var book = new Book(formatter)
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

            var paper = new Paper(formatter)
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
