using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CourseSurface.RightRectangleMethodLogic.Model;

namespace CourseSurface.RightRectangleMethodLogic
{
    public class RightRectangleMethod
    {
        public List<IntegrationResultInfo> CalculateSurface(Integral integrationInfo)
        {
            var results = new List<IntegrationResultInfo>();
            const int n = 1400;
            var surface = new Surface();

            var stopwatch = new Stopwatch();

            for (var i = 9; i < 10; i++)
            {
                stopwatch.Start();
                var result = RightRectangle(surface.CalculateSurfaceFunction, integrationInfo, n, i);
                stopwatch.Stop();

                results.Add(new IntegrationResultInfo() { Result = result, Time = stopwatch.Elapsed.TotalSeconds, NumberOfThreads = i });

                stopwatch.Reset();
            }

            return results;
        }


        public double RightRectangle(Func<double, double, double> f, Integral integrationInfo, int n, int threads)
        {
            var lockObject = new object();
            var stepX = GetStep(integrationInfo.XStart, integrationInfo.XEnd, n);
            var stepY = GetStep(integrationInfo.YStart, integrationInfo.YEnd, n);
            var sum = new ConcurrentBag<double>();

            var options = new ParallelOptions() { MaxDegreeOfParallelism = threads };

            using (var writer = new StreamWriter( threads + ".txt"))
            {
                Parallel.For(1, n + 1, options, i =>
                                                {
                                                    var time = new Stopwatch();

                                                    time.Start();

                                                    for (var j = 1; j < n + 1; j++)
                                                    {
                                                        sum.Add(f(GetByOffset(i, integrationInfo.XStart, stepX), GetByOffset(j, integrationInfo.YStart, stepY)));
                                                    }

                                                    time.Stop();

                                                    lock (lockObject)
                                                    {
                                                        writer.WriteLine(Thread.CurrentThread.ManagedThreadId + ":" + time.Elapsed.TotalSeconds + " : " + sum.Sum());
                                                    }
                                                });
            }

            return stepX * stepY * sum.Sum();
        }

        private double GetStep(double a, double b, int n) => ((b - a) / n);

        private double GetByOffset(int offset, double start, double step)
        {
            return start + offset * step;
        }
    }
}
