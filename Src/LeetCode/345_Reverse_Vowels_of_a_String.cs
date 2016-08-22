using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseVowelsofaString
    {
        public string Sollution(string s)
        {
            var flags = "aoeiuAOEIU";
            var result = new StringBuilder(s);
            var head = 0;
            var tail = result.Length - 1;
            while (head < tail)
            {
                while (head < tail && !flags.Contains(result[head]))
                {
                    head++;
                }
                while (tail > head && !flags.Contains(result[tail]))
                {
                    tail--;
                }
                if (flags.Contains(result[head]) && flags.Contains(result[tail]))
                {
                    var temp = result[head];
                    result[head] = result[tail];
                    result[tail] = temp;
                }
                head++;
                tail--;
            }
            return result.ToString();
        }

        public string Sollution_Fast(string s)
        {
            var flags = new char[] { 'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U' };
            var result = new StringBuilder(s);
            var head = 0;
            var tail = result.Length - 1;
            while (head < tail)
            {
                while (head < tail && !flags.Contains(result[head]))
                {
                    head++;
                }
                while (tail > head && !flags.Contains(result[tail]))
                {
                    tail--;
                }
                if (flags.Contains(result[head]) && flags.Contains(result[tail]))
                {
                    var temp = result[head];
                    result[head] = result[tail];
                    result[tail] = temp;
                }
                head++;
                tail--;
            }
            return result.ToString();
        }

        public string Sollution_Slower(string s)
        {
            var flags = new char[] { 'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U' };
            var result = new StringBuilder(s);
            var stack = new Stack<char>();
            var queue = new Queue<int>();
            for (int i = 0; i < result.Length; i++)
            {
                if (flags.Contains(result[i]))
                {
                    stack.Push(result[i]);
                    queue.Enqueue(i);
                }
            }
            while (queue.Count > 0)
            {
                result[queue.Dequeue()] = stack.Pop();
            }
            return result.ToString();
        }
    }
}
