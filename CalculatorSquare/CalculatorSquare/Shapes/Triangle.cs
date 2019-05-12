using System;
using CalculatorSquare.Interfaces;

namespace CalculatorSquare.Shapes
{
    public class Triangle : IShape
    {
        private int a { get; set; }

        private int b { get; set; }

        private int c { get; set; }

        public double Square => CalcSquare();

        private double CalcSquare()
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public Triangle(int _a, int _b, int _c)
        {
            if (_a + _b < _c || _b + _c < _a || _a + _c < _b)
                throw new Exception("Такого треугольника не существует!");

            a = _a;
            b = _b;
            c = _c;
        }

        public bool IsRectangular()
        {
            var squareA = Math.Pow(a, 2);
            
            var squareB = Math.Pow(b, 2);
            
            var squareC = Math.Pow(c, 2);

            if (squareA == squareB + squareC)
            {
                return true;
            }

            if (squareB == squareA + squareC)
            {
                return true;
            }

            return squareC == squareA + squareB;
        }
    }
}