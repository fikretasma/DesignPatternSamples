using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.OfferCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuotationCalculationFactory quotationCalculationFactory = new CaptiveQuotationCalculationFactory();
            decimal monthlRental = new QuotationCalculator(quotationCalculationFactory).Calculate();
            Console.WriteLine("MonthlyRental = {0}", monthlRental);
            Console.ReadLine();
        }
    }
}
