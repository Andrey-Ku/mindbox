using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void GetCircleAreaByRadiusTest()
        {
            var calc = new AreaCalculator();
            var r = 1;

            var area = calc.GetCircleAreaByRadius(r);

            Assert.AreEqual(Math.Round(Math.PI, 5), Math.Round(area, 5));
        }

        [TestMethod]
        public void GetCircleAreaByNegRadiusTest()
        {
            var calc = new AreaCalculator();
            var r = -1;

            Assert.ThrowsException<ArgumentException>(() => calc.GetCircleAreaByRadius(r));
        }

        [TestMethod]
        public void GetCircleAreaByInfRadiusTest()
        {
            var calc = new AreaCalculator();
            var r = double.PositiveInfinity;

            var area = calc.GetCircleAreaByRadius(r);

            Assert.AreEqual(double.PositiveInfinity, area);
        }

        [TestMethod]
        public void GetTriangleAreaBySidesTest()
        {
            var calc = new AreaCalculator();
            double a = 1, b = 1, c = 1;
            var expected = Math.Sqrt((a + b + c) * (a + b - c) * (a - b + c) * (b + c - a)) / 4;
            
            var area = calc.GetTriangleAreaBySides(a, b, c);
            
            Assert.AreEqual(Math.Round(expected, 4), Math.Round(area, 4));
        }

        [TestMethod]
        public void GetCircleAreaByNegSidesTest()
        {
            var calc = new AreaCalculator();
            double a = -1, b = 1, c = 1;

            Assert.ThrowsException<ArgumentException>(() => calc.GetTriangleAreaBySides(a, b, c));
        }

        [TestMethod]
        public void GetCircleAreaByMismatchSidesTest()
        {
            var calc = new AreaCalculator();
            double a = 3, b = 1, c = 1;

            Assert.ThrowsException<ArgumentException>(() => calc.GetTriangleAreaBySides(a, b, c));
        }
    }
}
