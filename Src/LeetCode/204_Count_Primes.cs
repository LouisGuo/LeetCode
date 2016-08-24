using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountPrimes
    {
        public int Sollution(int n)
        {
            if (n <= 2)
                return 0;
            var results = new List<int>(n - 2);
            for (int i = 2; i < n; i++)
            {
                results.Add(i);
            }
            for (int i = 0; i < results.Count; i++)
            {
                int current = results[i];
                var level = 2;
                var multi = current * level;
                while (multi <= results[results.Count - 1])
                {
                    for (int j = i + 1; j < results.Count; j++)
                    {
                        if (results[j] == multi)
                        {
                            results.RemoveAt(j);
                            break;
                        }
                    }
                    multi = current * (++level);
                }
            }
            return results.Count();
        }

        public int Sollution_Fast(int n)
        {
            if (n <= 2)
                return 0;
            var flags = new BitArray(n - 2);
            for (int i = 0; i < flags.Length; i++)
            {
                if (!flags[i])
                {
                    var current = i + 2;
                    var level = 2;
                    var multi = current * level;
                    while (multi < n)
                    {
                        flags[multi - 2] = true;
                        multi = current * (++level);
                    }
                }
            }
            var result = 0;
            foreach (Boolean flag in flags)
            {
                if (!flag)
                    result++;
            }
            return result;
        }

        public int Sollution_Faster(int n)
        {
            if (n <= 2)
                return 0;
            var max = Math.Sqrt(n);
            var flags = new BitArray(n);
            for (int i = 2; i <= max; i++)
            {
                if (!flags[i])
                {
                    var level = i;
                    var maxLevel = (n - 1) / i;
                    var multi = i * level;
                    while (level <= maxLevel)
                    {
                        flags[multi] = true;
                        multi = i * (++level);
                    }
                }
            }
            var result = 0;
            for (int i = 2; i < n; i++)
            {
                if (!flags[i])
                    result++;
            }
            return result;
        }

        public int Sollution_FasterEvenMore(int n)
        {
            if (n <= 2)
                return 0;
            var max = Math.Sqrt(n);
            var flags = new BitArray(n);
            var result = 0;
            for (int i = 2; i <= max; i++)
            {
                if (!flags[i])
                {
                    for (Int64 j = i * i; j < n; j += i)
                    {
                        flags[(int)j] = true;
                    }
                    result++;
                }
            }
            for (int i = (int)max + 1; i < n; i++)
            {
                if (!flags[i])
                    result++;
            }
            return result;
        }

        public int Sollution_Fastest(int n)
        {
            if (n <= 2)
                return 0;
            var max = Math.Sqrt(n);
            var flags = new BitArray(n);
            int count = n / 2;
            for (int i = 3; i <= max; i += 2)
            {
                if (flags[i])
                    continue;
                for (int j = i * i; j < n; j += 2 * i)
                {
                    if (!flags[j])
                    {
                        --count;
                        flags[j] = true;
                    }
                }
            }
            return count;
        }
    }
}
