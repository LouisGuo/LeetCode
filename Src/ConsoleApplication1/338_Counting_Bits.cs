using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Counting_Bits
    {
        public int[] Sollution(int num)
        {
            var result = new int[num + 1];
            var numCount = (int)Math.Log(num + 1, 2) + 1;
            var flags = new bool[numCount];
            for (int i = 1; i <= num; i++)
            {
                var lastIncrease = flags[0];
                flags[0] = !flags[0];
                for (int j = 1; lastIncrease && j < flags.Length; j++)
                {
                    lastIncrease = flags[j];
                    flags[j] = !flags[j];
                }
                result[i] = flags.Count(f => f);
            }
            return result;
        }
    }
}
