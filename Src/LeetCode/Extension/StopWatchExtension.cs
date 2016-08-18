using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class StopWatchExtension
    {
        public static TimeSpan Timing(this Stopwatch stopWatch, Action action)
        {
            stopWatch.Stop();
            var start = stopWatch.ElapsedTicks;
            stopWatch.Start();
            action();
            stopWatch.Stop();
            var end = stopWatch.ElapsedTicks;
            return new TimeSpan(end - start);
        }

        public static TimeSpan Timing(Action action)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            action();
            stopWatch.Stop();
            return new TimeSpan(stopWatch.ElapsedTicks);
        }
    }
}
