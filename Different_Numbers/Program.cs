using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a > 3)
            {
                for (int int1 = a; int1 <= b; int1++)
                {
                    for (int int2 = int1+1; int2 <= b; int2++)
                    {
                        for (int int3 = int2+1  ; int3 <= b; int3++)
                        {
                            for (int int4 = int3 + 1; int4 <= b; int4++)
                            {
                                for (int int5 = int4+1; int5 <= b; int5++)
                                {
                                    Console.WriteLine($"{int1} {int2} {int3} {int4} {int5}");
                                }
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("No");
        }
    }
}
