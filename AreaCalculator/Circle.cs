using System;

namespace Calculator
{
    public struct Circle : IFlatFigure
    {
        private readonly double _r;

        public Circle(double r)
        {
            if (r <= 0) throw new ArgumentException("Radius must be greater than zero.");

            _r = r;
        }

        public double GetArea()
        {
            return Math.PI * _r * _r;
        }
    }
}
