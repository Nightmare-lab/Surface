using System;

namespace CourseSurface.RightRectangleMethodLogic
{
    public class Surface
    {
        private readonly Diffrentiation _diffrentiation;

        public Surface()
        {
            _diffrentiation = new Diffrentiation();
        }

        public double CalculateInitialFunction(double x, double y)
        {
            return 2 * x * x + 2 * y * y + 3 * Math.Exp(-x) + 3 * Math.Exp(y);
        }

        private double CalculateXDerivative(double x, double y)
        {
            //return A*2*x+C*Math.Cos(x) * Math.Cos(y);
            return _diffrentiation.CalculateXDerivative(CalculateInitialFunction, x, y);
        }

        private double CalculateYDerivative(double x, double y)
        {
            //return B*2*y-C*Math.Sin(x) * Math.Sin(y);
            return _diffrentiation.CalculateYDerivative(CalculateInitialFunction, x, y);
        }

        public double CalculateSurfaceFunction(double x, double y)
        {
            return Math.Sqrt(1 + Math.Pow(CalculateXDerivative(x, y), 2) + Math.Pow(CalculateYDerivative(x, y), 2));
        }
    }
}