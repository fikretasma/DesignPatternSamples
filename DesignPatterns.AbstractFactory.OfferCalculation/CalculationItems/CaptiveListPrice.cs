using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    internal class CaptiveListPrice : ListPrice
    {
        internal override decimal Calculate()
        {
            return 4;
        }
    }
}
