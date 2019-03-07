using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    internal class CaptiveQuotationCalculationFactory : QuotationCalculationFactory
    {
        public override ListPrice CreateListPrice()
        {
            return new CaptiveListPrice();
        }

        public override StampTax CreateStampTax()
        {
            return new CaptiveStampTax();
        }

        public override VehicleTax CreateVehicleTax()
        {
            return new CaptiveVehicleTax();
        }
    }
}
