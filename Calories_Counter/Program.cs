using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfIngredients = int.Parse(Console.ReadLine());

            var cheeseCal = 500;
            var tomatoSauceCal = 150;
            var salamiCal = 600;
            var pepperCal = 50;
            var pizzaCal = 0;


            for (int i = 1; i <= numberOfIngredients; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                if (ingredient=="cheese")
                {
                    pizzaCal += cheeseCal;
                }
                else if (ingredient == "tomato sauce")
                {
                    pizzaCal += tomatoSauceCal;
                }
                else if (ingredient == "salami")
                {
                    pizzaCal += salamiCal;
                }
                else if (ingredient == "pepper")
                {
                    pizzaCal += pepperCal;
                }
            }
            Console.WriteLine($"Total calories: {pizzaCal}");
        }
    }
}
