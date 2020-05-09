using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            for (var i = 1; i < 10; i++)
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
            var stepX = GetStep(integrationInfo.XStart, integrationInfo.XEnd, n);
            var stepY = GetStep(integrationInfo.YStart, integrationInfo.YEnd, n);
            var sum = new ConcurrentBag<double>();

            var options = new ParallelOptions() { MaxDegreeOfParallelism = threads };

            Parallel.For(0, n, options, i =>
                                           {
                                               for (var j = 0; j < n; j++)
                                               {
                                                   sum.Add(f(GetByOffset(i + 1, integrationInfo.XStart, stepX),
                                                                 GetByOffset(j + 1, integrationInfo.YStart, stepY)));
                                               }
                                           }
                                );


            return stepX * stepY * sum.Sum();
        }

        private double GetStep(double a, double b, int n) => ((b - a) / n);

        private double GetByOffset(int offset, double start, double step)
        {
            return start + offset * step;
        }
    }
}
