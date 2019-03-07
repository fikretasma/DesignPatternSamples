using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Meal
{
    public class MealDirector
    {
        public void MakeMeal(MealBuilder mealBuilder)
        {
            mealBuilder.AddSandwich();
            mealBuilder.AddSideOrder();
            mealBuilder.AddDrink();
            mealBuilder.AddOfferItem();
            mealBuilder.SetPrice();
        }
    }
}
