using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            var drink = "";

            if (profession == "athlete")
            {
                drink = "Water";
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession =="softuni student")
            {
                drink = "Beer";
            }
            else 
            {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
