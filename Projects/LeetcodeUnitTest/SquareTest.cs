using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareTestNormal()
        {
            Square s = new Square();
            int case1 = 2;
            int case2 = 64;
            int case3 = 65;
            int case4 = 63;
            int case5 = 512;
            int case6 = 300;
            int case7 = 1000;
            Assert.AreEqual((int)Math.Sqrt(case1), s.MySqrt(case1));
            Assert.AreEqual((int)Math.Sqrt(case2), s.MySqrt(case2));
            Assert.AreEqual((int)Math.Sqrt(case3), s.MySqrt(case3));
            Assert.AreEqual((int)Math.Sqrt(case4), s.MySqrt(case4));
            Assert.AreEqual((int)Math.Sqrt(case5), s.MySqrt(case5));
            Assert.AreEqual((int)Math.Sqrt(case6), s.MySqrt(case6));
            Assert.AreEqual((int)Math.Sqrt(case7), s.MySqrt(case7));
        }
    }
}
