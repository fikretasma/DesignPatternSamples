using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    internal class QuotationCalculator
    {
        private ListPrice ListPrice;
        private VehicleTax VehicleTax;
        private StampTax StampTax;


        internal QuotationCalculator(QuotationCalculationFactory quotationCalculationFactory)
        {
            this.ListPrice = quotationCalculationFactory.CreateListPrice();
            this.VehicleTax = quotationCalculationFactory.CreateVehicleTax();
            this.StampTax = quotationCalculationFactory.CreateStampTax();
        }

        internal decimal Calculate()
        {
            decimal result = 0;
            result += this.ListPrice.Calculate();
            result += this.VehicleTax.Calculate();
            result += this.StampTax.Calculate();

            return result;
        }
    }
}
