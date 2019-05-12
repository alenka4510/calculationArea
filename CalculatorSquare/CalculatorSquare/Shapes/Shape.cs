using CalculatorSquare.Interfaces;

namespace CalculatorSquare.Shapes
{
    public class Shape : IShape
    {
        public double Square => shape.Square;

        private IShape shape;

        public Shape(IShape _shape)
        {
            shape = _shape;
        }
    }
}