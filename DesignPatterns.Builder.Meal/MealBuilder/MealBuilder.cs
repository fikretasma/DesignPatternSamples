using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Meal
{
    public abstract class MealBuilder
    {
        public abstract void AddSandwich();
        public abstract void AddSideOrder();
        public abstract void AddDrink();
        public abstract void AddOfferItem();
        public abstract void SetPrice();
        public abstract Meal GetMeal();
    }
}
