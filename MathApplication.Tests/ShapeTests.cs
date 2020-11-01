using System;
using MathApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathApplication.Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void EquilateralTriangleTest()
        {
            Triangle triangleTwo = new Triangle(2.0, 2.0, 2.0);

            Assert.AreEqual("Equilateral", triangleTwo.Name);
            Assert.AreEqual(6, triangleTwo.Perimeter());
            Assert.AreEqual(2, triangleTwo.SurfaceArea());
        }

        [TestMethod]
        public void ScaleneTriangleTest1()
        {
            Triangle triangleOne = new Triangle(1.0, 2.0, 3.0);
            Assert.AreEqual("Scalene", triangleOne.Name);
            Assert.AreEqual(6, triangleOne.Perimeter());
            Assert.AreEqual(1.5, triangleOne.SurfaceArea());
        }
        [TestMethod]
        public void IsosclelesTriangleTest1()
        {
            Triangle triangleThree = new Triangle(2.0, 2.0, 3.0);
            Assert.AreEqual("Isoscleles", triangleThree.Name);
            Assert.AreEqual(7, triangleThree.Perimeter());
            Assert.AreEqual(2, triangleThree.SurfaceArea());
        }

        [TestMethod]
        public void CircleTest()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                Circle circle = new Circle(i);

                Assert.AreEqual(Math.PI * 2 * i, circle.Perimeter());
                Assert.AreEqual("Circle", circle.Name);
                Assert.AreEqual(Math.PI * i * i, circle.SurfaceArea());
                Assert.AreEqual(i, Circle.Count);
            }
        }


        [TestMethod]
        public void RectangleTest()
        {
            Rectangle rectangle = new Rectangle(2, 2);

            Assert.AreEqual(8, rectangle.Perimeter());
            Assert.AreEqual(4, rectangle.SurfaceArea());
            Assert.AreEqual(1, Rectangle.Count);
            Assert.AreEqual("Rectangle", rectangle.Name);
        }

        [TestMethod]
        public void SquareTest()
        {
            Square square = new Square(2);

            Assert.AreEqual(8, square.Perimeter());
            Assert.AreEqual(4, square.SurfaceArea());
            Assert.AreEqual(1, Square.Count);
            Assert.AreEqual("Square", square.Name);
            Assert.AreEqual(square.Height, square.Width);
        }
    }
}

