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
            const int n = 2500;
            var surface = new Surface();

            var stopwatch = new Stopwatch();

            for (var i = 1; i < 10; i++)
            {
                stopwatch.Start();
                var result = RightRectangle(surface.CalculateSurfaceFunction, integrationInfo, n, i);
                stopwatch.Stop();

                results.Add(new IntegrationResultInfo {Result = result, Time = stopwatch.Elapsed.TotalSeconds, NumberOfThreads = i});

                stopwatch.Reset();
            }

            return results;
        }


        public double RightRectangle(Func<double, double, double> f, Integral integrationInfo, int n, int threads)
        {
            var lockObject = new object();
            var stepX = GetStep(integrationInfo.XStart, integrationInfo.XEnd, n);
            var stepY = GetStep(integrationInfo.YStart, integrationInfo.YEnd, n);
            var totalSum = 0.0;
            var time = new Stopwatch();
            time.Start();

            var options = new ParallelOptions {MaxDegreeOfParallelism = threads};

            using (var writer = new StreamWriter(threads + ".txt"))
            {
                Parallel.For<double>(1, (long)n + 1, options, () => 0, (i, state, subtotal) =>
                                                         {
                                                             for (var j = 1; j < n + 1; j++)
                                                             {
                                                                 subtotal += f(GetByOffset((int)i, integrationInfo.XStart, stepX),
                                                                               GetByOffset(j, integrationInfo.YStart, stepY));
                                                             }

                                                             return subtotal;
                                                         }, sum =>
                                                            {
                                                                lock (lockObject)
                                                                {
                                                                    time.Stop();
                                                                    totalSum += sum;
                                                                    writer.WriteLine(Thread.CurrentThread.ManagedThreadId + " : " + time.Elapsed.TotalSeconds + ":" + totalSum);
                                                                    time.Start();
                                                                }
                                                            });
            }

            return stepX * stepY * totalSum;
        }

        private double GetStep(double a, double b, int n)
        {
            return (b - a) / n;
        }

        private double GetByOffset(int offset, double start, double step)
        {
            return start + offset * step;
        }
    }
}