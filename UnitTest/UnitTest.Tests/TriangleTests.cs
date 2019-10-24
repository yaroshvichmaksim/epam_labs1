using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void All_Sides_Are_Negative()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 =triangle.Triangle_Inequality(-20, -20, -30);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void All_Sides_Are_Positive()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10.5, 12.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_A_And_B_Bigger_Than_C()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10.5, 12.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_A_And_B_Less_Than_C()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(7.5, 7.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_B_And_C_Bigger_Than_A()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10.5, 12.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_B_And_C_Less_Than_A()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10.5, 2.5, 5.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_A_And_C_Bigger_Than_B()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10.5, 12.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void Sum_A_And_C_Less_Than_B()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(1.5, 12.5, 5.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void A_Side_Is_Negative()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(-10.5, 12.5, 15.3);
            Assert.AreEqual(sum, sum1);
        }
        [TestMethod]
        public void All_Sides_Are_Equal()
        {
            bool sum = true;
            Triangle triangle = new Triangle();
            bool sum1 = triangle.Triangle_Inequality(10, 10, 10);
            Assert.AreEqual(sum, sum1);
        }
    }
}
