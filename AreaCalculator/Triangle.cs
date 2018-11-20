using System;

namespace Calculator
{
    public struct Triangle : IFlatFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        // строго говоря, задание треугольника тремя сторонами невалидно,
        // правильно было бы задавать координаты вершин
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero.");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Side length mismatch.");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            // по теореме пифагора проверяем является ли треугольник прямоугольным
            if (_a * _a + _b * _b == _c * _c) return _a * _b;
            if (_b * _b + _c * _c == _a * _a) return _b * _c;
            if (_a * _a + _c * _c == _b * _b) return _a * _c;

            // иначе считаем по формуле герона
            return Math.Sqrt(
                (_a + _b + _c) * (_a + _b - _c) * (_a - _b + _c) * (_b + _c - _a)
                ) / 4;

        }
    }
}
