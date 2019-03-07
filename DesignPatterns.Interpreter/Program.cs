using DesignPatterns.Interpreter.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Create the context (i.e. roman value)
            string roman = "CXXVIII"; 
            var context = new Context { Input = roman };

            // Interpret
            tree.ForEach(e => e.Interpret(context));

            Console.WriteLine("{0} = {1}", roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }
}
