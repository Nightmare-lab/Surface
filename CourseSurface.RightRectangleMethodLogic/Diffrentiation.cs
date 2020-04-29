using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSurface.RightRectangleMethodLogic
{
    class Diffrentiation
    {
        const double Epsilon = 1e-6;

        public double CalculateXDerivative(Func<double, double, double> function, double x, double y)
        {
            var xStep = 0.0;

            xStep = Epsilon;


            var derivative = (function(x + xStep, y) - function(x - xStep, y)) / (2 * (xStep));
            return derivative;
        }

        public double CalculateYDerivative(Func<double, double, double> function, double x, double y)
        {
            var yStep = 0.0;
            
            yStep = Epsilon;


            var derivative = (function(x, y + yStep) - function(x, y - yStep)) / (2 * (yStep));
            return derivative;
        }
    }
}
