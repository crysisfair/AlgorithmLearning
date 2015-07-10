using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class LargestRectInHistogramTest
    {
        [TestMethod]
        public void LargetRectInHistogramNormalCase()
        {
            int[] testCase1 = new int[] { 2, 1, 5, 6, 2, 3 };
            int[] testCase2 = new int[] { 2, 2, 2, 2, 2, 2 };
            int[] testCase3 = new int[] { 2, 2, 2, 1, 2};
            int[] testCase4 = new int[] { 2, 2, 1, 2, 2};
            LargestRectangleInHistogram l = new LargestRectangleInHistogram();
            Assert.AreEqual(l.LargestRectangleArea(testCase1), 10);
            Assert.AreEqual(l.LargestRectangleArea(testCase2), 12);
            Assert.AreEqual(l.LargestRectangleArea(testCase3), 6);
            Assert.AreEqual(l.LargestRectangleArea(testCase4), 5);
        }
    }
}
