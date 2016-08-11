using System;
using System.Collections;
using System.Collections.Generic;
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

            for (int i = 0; i < Math.Pow(2, 5); i++)
            {
                Console.WriteLine(String.Join(", ", tool.Sollution(i)));
            }

            Console.ReadKey();
        }
    }
}
