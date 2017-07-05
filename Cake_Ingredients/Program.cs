using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var ingredient = "";
            while (ingredient != "Bake!") 
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
            } 
        }
    }
}
