using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Meal
{
    class Program
    {
        static void Main(string[] args)
        {
            MealDirector director = new MealDirector();
            MealBuilder vegeterianMealBuilder = new VegetarianMealBuilder();
            director.MakeMeal(vegeterianMealBuilder);
            Meal vegeterianMeal = vegeterianMealBuilder.GetMeal();
            Console.WriteLine(vegeterianMeal);
            Console.WriteLine();

            MealBuilder mealBuilder = new MexicanMealBuilder();
            director.MakeMeal(mealBuilder);
            Meal mexicanMeal = mealBuilder.GetMeal();
            Console.WriteLine(mexicanMeal);

        }
    }
}
