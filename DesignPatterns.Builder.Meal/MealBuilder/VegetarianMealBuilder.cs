using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Meal
{
    public class VegetarianMealBuilder : MealBuilder
    {
        private Meal _meal = new Meal();
        public override void AddSandwich() { _meal.Sandwich = "Vegeburger"; }
        public override void AddSideOrder() { _meal.SideOrder = "Fries"; }
        public override void AddDrink() { _meal.Drink = "Orange juice"; }
        public override void AddOfferItem() { _meal.Offer = "Donut voucher"; }
        public override void SetPrice() { _meal.Price = 4.99; }
        public override Meal GetMeal() { return _meal; }
    }
}
