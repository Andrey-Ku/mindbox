using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IAreaCalculator
    {
        double GetTriangleAreaBySides(double a, double b, double c);

        double GetCircleAreaByRadius(double r);
    }
}
