using System;
using CalculatorSquare.Interfaces;

namespace CalculatorSquare.Shapes
{
    public class Circle : IShape
    {
        private int r { get; set; }
        public double Square => Math.PI * Math.Pow(r, 2);

        public Circle(int _r)
        {
            r = _r;
        }
    }
}