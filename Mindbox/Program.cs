using Calculator;
using System;
using System.Text.RegularExpressions;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ctrl-C to exit");
            Console.WriteLine();

            var calc = new AreaCalculator();
            while (true)
            {
                Console.WriteLine("Enter figure name:\r\ncircle - c\r\ntriangle - t");
                var key = Console.ReadKey().KeyChar;

                Console.WriteLine();
                double area = 0;

                try
                {

                    switch (key)
                    {
                        case 'c':
                            {
                                Console.Write("Enter circle radius: ");
                                var str = Console.ReadLine();

                                var r = double.Parse(str);
                                area = calc.GetCircleAreaByRadius(r);

                                Console.WriteLine($"Circle area ({r}) = {area}");
                                break;
                            }
                        case 't':
                            {
                                Console.Write("Enter space delimited triangle sides: ");
                                var str = Console.ReadLine();

                                var match = Regex.Match(str, @"(\d+)\s+(\d+)\s+(\d+)");
                                if (match.Success)
                                {
                                    double a = double.Parse(match.Groups[1].Value);
                                    double b = double.Parse(match.Groups[2].Value);
                                    double c = double.Parse(match.Groups[3].Value);
                                    area = calc.GetTriangleAreaBySides(a, b, c);

                                    Console.WriteLine($"Triangle area ({a}, {b}, {c}) =  {area}");
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input values: " + str);
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unknown figure: " + key);
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error - " + ex.Message);
                }

                Console.WriteLine();
            }
        }
    }
}
