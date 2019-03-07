using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    abstract class CalculatorItem
    {
        internal abstract decimal Calculate();
    }
}
