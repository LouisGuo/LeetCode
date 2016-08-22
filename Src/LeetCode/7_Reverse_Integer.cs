using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {
        public int Sollution(int x)
        {
            var isPositive = x >= 0;
            var strX = x.ToString();
            if (!isPositive)
                strX = strX.Substring(1, strX.Length - 1);
            var reversed = new String(strX.Reverse().ToArray());
            var result = double.Parse(reversed);
            if (result > Int32.MaxValue)
                result = 0;
            if (!isPositive)
                result = result * (-1);
            return (int)result;
        }

        public int Sollution_Fast(int x)
        {
            var stack = new Stack<double>();
            while (x != 0)
            {
                stack.Push(x % 10);
                x = x / 10;
            }
            var levelBase = 1d;
            var result = 0d;
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                result += temp * levelBase;
                levelBase *= 10;
            }
            if (result < int.MinValue || result > int.MaxValue)
                result = 0;
            return (int)result;
        }
    }
}
