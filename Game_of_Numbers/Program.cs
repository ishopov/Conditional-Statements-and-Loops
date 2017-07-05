using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var counter = 0;
            string combination = "";

            if (M < N) Console.WriteLine("Please enter the second number greater to the first one!");
            else
            {
                for (int i = N; i <= M; i++)
                {
                    for (int j = N; j <= M; j++)
                    {
                        if (i + j == magicNumber)
                        {
                            combination = $"{i} + {j}";
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                if (combination!="")
                {
                    Console.WriteLine($"Number found! {combination} = {magicNumber}");
                }
                else Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
