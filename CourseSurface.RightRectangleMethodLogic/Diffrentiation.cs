using System;

namespace CourseSurface.RightRectangleMethodLogic
{
    internal class Diffrentiation
    {
        const double Epsilon = 1e-6;

        public double CalculateXDerivative(Func<double, double, double> function, double x, double y)
        {
            const double xStep = Epsilon;


            var derivative = (function(x + xStep, y) - function(x - xStep, y)) / (2 * (xStep));
            return derivative;
        }

        public double CalculateYDerivative(Func<double, double, double> function, double x, double y)
        {
            const double yStep = Epsilon;


            var derivative = (function(x, y + yStep) - function(x, y - yStep)) / (2 * (yStep));
            return derivative;
        }
    }
}
