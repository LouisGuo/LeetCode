using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class UTF8Validation
    {
        public bool Solution(int[] data)
        {
            if (data != null && data.Length > 0)
            {
                var current = 0;
                while (current < data.Length)
                {
                    var next = GetNext(data[current]);
                    if (next >= 0 && current + next < data.Length)
                    {
                        for (int i = 1; i <= next; i++)
                        {
                            if (data[current + i] < 128 || data[current + i] > 191)
                            {
                                return false;
                            }
                        }
                        current = current + next + 1;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int GetNext(int val)
        {
            if (val >= 0 && val <= 127)
                return 0;
            else if (val >= 192 && val <= 223)
                return 1;
            else if (val >= 224 && val <= 239)
                return 2;
            else if (val >= 240 && val <= 247)
                return 3;
            else
                return -1;
        }
    }
}
