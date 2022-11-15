using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class CircumferenceTest
    {
        [TestMethod]
        public void CircumferenceAreaTestMethod()
        {
            //Arrange
            double radius = 3;
            double expected = 28.274333882308138;

            //Act
            Circumference circle = new Circumference(radius);
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void CircumferencePerimeterTestMethod()
        {
            //Arrange
            double radius = 3;
            double expected = 18.849555921538759430775860299677;

            //Act
            Circumference circle = new Circumference(radius);
            double actual = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
