using System;
using System.IO;
using System.Linq;
using CalculatorSquare.Shapes;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestProject1
{
    public class AppTests
    {
        [Test]
        public void CalcSquareCircleTest()
        {
            var circle = new Circle(2);

            var square = circle.Square;

            Assert.AreEqual(Math.Round(square, 2), 12.57);
        }
        
        [Test]
        public void IsRectangularTest()
        {
            var tr = new Triangle(3, 4, 5);

            var isRectangular = tr.IsRectangular();

            Assert.AreEqual(isRectangular, true);
        }
        
        [Test]
        public void IsNotRectangularTest()
        {
            var tr = new Triangle(3, 4, 6);

            var isRectangular = tr.IsRectangular();

            Assert.AreEqual(isRectangular, false);
        }
        
        [Test]
        public void CalcSquareTriangleTest()
        {
            var tr = new Triangle(3, 4, 5);

            var square = tr.Square;

            Assert.AreEqual(square, 6);
        } 
        
        [Test]
        public void CreateNotValidTriangleTest()
        {
            try
            {
                var tr = new Triangle(2, 4, 20);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Такого треугольника не существует!", e.Message);
            }
        }
    }
}