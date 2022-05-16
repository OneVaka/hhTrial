using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace hhTrial.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_3_4_5_Area_Returns6()
        {
            // arrange
            var triag = new Triangle(3, 4, 5);

            // act
            var res = triag.getArea();

            // assert
            Assert.AreEqual(6, res);
        }



        [TestMethod]
        public void Triangle_3_4_5_checkStraight_ReturnsTrue()
        {
            // arrange
            var triag = new Triangle(3, 4, 5);

            // act
            var res = Triangle.checkSrtaight(triag);

            // assert
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Triangle_3_4_6_checkStraight_ReturnsFalse()
        {
            // arrange
            var triag = new Triangle(3, 4, 6);

            // act
            var res = Triangle.checkSrtaight(triag);

            // assert
            Assert.AreEqual(false, res);
        }
    }

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_3_Area_Returns38485()
        {
            // arrange
            var circle = new Circle(3.5);

            // act
            var res = circle.Area;

            // assert
            Assert.AreEqual(38.485, Math.Round(res,3));
        }

    }
}
