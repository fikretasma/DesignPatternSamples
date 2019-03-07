using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    internal class HeadQuarterQuotationCalculationFactory : QuotationCalculationFactory
    {
        public override ListPrice CreateListPrice()
        {
            return new HeadQuarterListPrice();
        }

        public override StampTax CreateStampTax()
        {
            return new HeadQuarterStampTax();
        }

        public override VehicleTax CreateVehicleTax()
        {
            return new HeadQuarterVehicleTax();
        }
    }
}
