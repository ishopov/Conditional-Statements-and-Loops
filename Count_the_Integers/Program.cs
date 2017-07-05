using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo = 0;
            var counter = 0;
            var tryParsed = true;
            do
            {
                var element = Console.ReadLine();
                tryParsed = int.TryParse(element, out chislo);
                if (tryParsed)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                }

            } while (tryParsed);


        }
    }
}
