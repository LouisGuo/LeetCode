using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddBinary
    {
        public string Sollution(string a, string b)
        {
            var result = String.Empty;
            var lastIncrease = false;
            for (int i = 0; i < a.Length || i < b.Length; i++)
            {
                var currentCount = 0;
                var current = '0';
                var aChar = ' ';
                var bChar = ' ';
                var aIndex = a.Length - 1 - i;
                var bIndex = b.Length - 1 - i;
                if (aIndex >= 0)
                    aChar = a[aIndex];
                if (bIndex >= 0)
                    bChar = b[bIndex];
                if (lastIncrease)
                    currentCount++;
                if (aChar.Equals('1'))
                    currentCount++;
                if (bChar.Equals('1'))
                    currentCount++;
                lastIncrease = currentCount >1;
                if (currentCount == 1 || currentCount == 3)
                    current = '1';
                result = current + result;
            }
            if (lastIncrease)
                result = '1' + result;
            return result;
        }
    }
}
