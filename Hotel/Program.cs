using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Second_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nights;
                doublePrice = 65 * nights;
                suitePrice = 75 * nights;
                if (nights > 7 && month == "October")
                {
                    studioPrice -= 50;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nights;
                doublePrice = 72 * nights;
                suitePrice = 82 * nights;
                if (nights > 7 && month == "September")
                {
                    studioPrice -= 60;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nights;
                doublePrice = 77 * nights;
                suitePrice = 89 * nights;
            }

            if (nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice * 0.95;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doublePrice = doublePrice * 0.9;
            }
            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suitePrice = suitePrice * 0.85;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
