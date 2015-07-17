using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class LargestNumberTest
    {
        [TestMethod]
        public void LargestNumberTestNormal()
        {
            LargestNumer l = new LargestNumer();
            int[] case1 = new int[] { 123, 113, 133 };
            int[] case2 = new int[] { 1, 11, 12};
            int[] case3 = new int[] { 1, 10, 110, 12};
            int[] case4 = new int[] { 0, 00};
            int[] case5 = new int[] { 1 };
            int[] case6 = new int[] { 0, 0, 1};

            Assert.AreEqual("133123113", l.LargestNumber(case1));
            Assert.AreEqual("12111", l.LargestNumber(case2));
            Assert.AreEqual("12111010", l.LargestNumber(case3));
            Assert.AreEqual("0", l.LargestNumber(case4));
            Assert.AreEqual("1", l.LargestNumber(case5));
            Assert.AreEqual("100", l.LargestNumber(case6));
        }
    }
}
