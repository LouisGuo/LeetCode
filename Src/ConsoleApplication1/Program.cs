using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var tool = new Counting_Bits();
            var max = (int)Math.Pow(2, 27);
            
            var stopWatch = new Stopwatch();

            var time = stopWatch.Timing(() => { tool.Sollution(max); });
            var time1 = stopWatch.Timing(() => { tool.Sollution_Fast(max); });
            
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(String.Join(", ", tool.Sollution_Fast(i)));
            }

            Console.ReadKey();
        }
    }
}
