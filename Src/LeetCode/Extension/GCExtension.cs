using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class GCExtension
    {
        public static long MemoryIncrease(Action action)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            var start = GC.GetTotalMemory(false);
            action();
            var end = GC.GetTotalMemory(false);
            return end - start;
        }
    }
}
