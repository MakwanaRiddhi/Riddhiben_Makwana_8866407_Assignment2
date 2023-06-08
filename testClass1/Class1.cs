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
           
        }
    }
}
