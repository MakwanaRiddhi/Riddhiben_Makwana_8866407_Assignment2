using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace testClass1
{
    [TestFixture]
    public class Class1
    {
        //	Only one (1) test for a valid equilateral triangle
        [Test]
        public void ValidEquilateralTriangle_Input47and47and47_OutputValidEquilateralTriangle()
        {
            //Arrange
            int firstside = 47;
            int secondside = 47;
            int thirdside = 47;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
           string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Three (3) tests for a valid isosceles triangle
        [Test]
        public void ValidIsoscelesTriangle_Input35and35and50_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstside = 35;
            int secondside = 35;
            int thirdside = 50;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidIsoscelesTriangle_Input50and35and35_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstside = 50;
            int secondside = 35;
            int thirdside = 35;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidIsoscelesTriangle_Input35and50and35_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstside = 35;
            int secondside = 50;
            int thirdside = 35;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
