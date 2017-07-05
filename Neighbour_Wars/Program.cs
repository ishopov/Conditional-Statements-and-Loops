using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoSDamage = int.Parse(Console.ReadLine());
            var goshoSDamage = int.Parse(Console.ReadLine());

            var peshoSHealth = 100;
            var goshoSHealth = 100;
            var round = 0;

            while (peshoSHealth > 0 && goshoSHealth > 0)
            {
                
                round++;                
                goshoSHealth -= peshoSDamage;
                if (goshoSHealth > 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoSHealth} health.");
                    if (round % 3 == 0)
                    {
                        goshoSHealth += 10;
                        peshoSHealth += 10;
                    }
                    round++;
                    peshoSHealth -= goshoSDamage;

                    if (peshoSHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoSHealth} health.");
                        if (round % 3 == 0)
                        {
                            goshoSHealth += 10;
                            peshoSHealth += 10;
                        }
                    }
                    else if (peshoSHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                    }

                    
                }
                else if (goshoSHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                }
                
            }
        }
    }
}
