using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSurface.RightRectangleMethodLogic
{
    public class RightRectangleMethod
    {
        private double RightRectangle(Func<double, double> f, double a, double b, int n)
        {
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * GetStep(a,b,n);
                sum += f(x);
            }

            var result = GetStep(a, b, n) * sum;
            return result;
        }

        private double GetStep(double a, double b, int n) => ((b - a) / n);

    }
}
