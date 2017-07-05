using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var amount = int.Parse(Console.ReadLine());
            var drinkPrice = 0.0;

            if (profession == "Athlete")
            {
                drinkPrice = amount * 0.7;

            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drinkPrice = amount * 1.0;
            }
            else if (profession == "SoftUni Student")
            {
                drinkPrice = amount * 1.70;
            }
            else
            {
                drinkPrice = amount * 1.20;
            }

            Console.WriteLine($"The {profession} has to pay {drinkPrice:f2}.");
        }
    }
}
