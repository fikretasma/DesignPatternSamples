using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentBadSolution
{
    public abstract class Document
    {
        protected readonly IFormatter Formatter;
        public Document(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        abstract public void Print();
    }
}
