using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void TrianglePerimeterTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 12;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
