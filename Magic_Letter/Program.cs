using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine().ToLower());
            char lastLetter = char.Parse(Console.ReadLine().ToLower());
            char exceptLetter = char.Parse(Console.ReadLine().ToLower());

            for (char x = firstLetter; x <= lastLetter; x++)
            {
                for (char y = firstLetter; y <= lastLetter; y++)
                {
                    for (char z = firstLetter; z <= lastLetter; z++)
                    {
                        if (x != exceptLetter && y != exceptLetter && z != exceptLetter)
                        {
                            Console.Write($"{x}{y}{z} ");
                        }                        
                    }
                }
            }
        }
    }
}
