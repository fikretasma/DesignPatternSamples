using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    abstract class QuotationCalculationFactory
    {
        public abstract ListPrice CreateListPrice();
        public abstract StampTax CreateStampTax();
        public abstract VehicleTax CreateVehicleTax();
    }
}
