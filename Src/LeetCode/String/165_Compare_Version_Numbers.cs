using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CompareVersionNumbers
    {
        public int Solution(string version1, string version2)
        {
            var v1 = version1.Split('.').Select(i => int.Parse(i)).ToList();
            var v2 = version2.Split('.').Select(i => int.Parse(i)).ToList();
            for (int i = v1.Count - 1; i > 0; i--)
            {
                if (v1[i] != 0)
                    break;
                else
                    v1.RemoveAt(i);
            }
            for (int i = v2.Count - 1; i > 0; i--)
            {
                if (v2[i] != 0)
                    break;
                else
                    v2.RemoveAt(i);
            }
            for (int i = 0; i < v1.Count && i < v2.Count; i++)
            {
                if (v1[i] > v2[i])
                    return 1;
                else if (v2[i] > v1[i])
                    return -1;
                else
                    continue;
            }
            if (v1.Count > v2.Count)
                return 1;
            else if (v2.Count > v1.Count)
                return -1;
            else
                return 0;
        }

        public int Solution_Fast(string version1, string version2)
        {
            int l1 = version1.Length;
            int l2 = version2.Length;
            int v1 = 0;
            int v2 = 0;

            int i1 = 0;
            int i2 = 0;

            while (i1 < l1 || i2 < l2)
            {

                while (i1 < l1 && version1[i1] != '.')
                {
                    v1 = 10 * v1 + (version1[i1] - '0');
                    i1++;
                }

                while (i2 < l2 && version2[i2] != '.')
                {
                    v2 = 10 * v2 + (version2[i2] - '0');
                    i2++;
                }

                if (v1 > v2) return 1;
                else if (v1 < v2) return -1;
                else
                {
                    v1 = 0;
                    v2 = 0;
                    i1++;
                    i2++;
                }
            }

            return 0;
        }
    }
}
