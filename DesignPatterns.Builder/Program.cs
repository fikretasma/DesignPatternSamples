using DesignPatterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderFactory screenBuilderFactory = new BuilderFactory();
            Screen screen = screenBuilderFactory.Build();
        }
    }
}
