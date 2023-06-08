﻿using System;
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
        //	1.Only one (1) test for a valid equilateral triangle
        [Test]//test1.1
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

        //2.Three (3) tests for a valid isosceles triangle
        [Test]//test2.1
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
        [Test]//test2.2
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
        [Test]//test2.3
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
        //3.Five (5) tests for a valid scalene triangle
        [Test]//test3.1
        public void ValidScaleneTriangle_Input45and40and80_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 45;
            int secondside = 40;
            int thirdside = 80;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]//test3.2
        public void ValidScaleneTriangle_Input62and57and96_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 62;
            int secondside = 57;
            int thirdside = 96;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]//test3.3
        public void ValidScaleneTriangle_Input56and51and98_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 56;
            int secondside = 51;
            int thirdside = 98;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]//test3.4
        public void ValidScaleneTriangle_Input30and41and60_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 30;
            int secondside = 41;
            int thirdside = 60;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]//test3.5
        public void ValidScaleneTriangle_Input62and31and35_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 62;
            int secondside = 31;
            int thirdside = 35;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
