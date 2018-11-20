using System;

namespace Calculator
{
    public class AreaCalculator : IAreaCalculator
    {
        public double GetCircleAreaByRadius(double r)
        {
            return new Circle(r).GetArea();
        }

        public double GetTriangleAreaBySides(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }
    }
}
