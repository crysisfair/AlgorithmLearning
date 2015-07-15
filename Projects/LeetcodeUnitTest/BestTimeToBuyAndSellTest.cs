using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class BestTimeToBuyAndSellTest
    {
        [TestMethod]
        public void BestTimeToButAndSellNormal()
        {
            BestTimeToBuyAnsSell b = new BestTimeToBuyAnsSell();
            int[] case1 = new int[] { 1, 2, 3 };
            int[] case2 = new int[] { 3, 2, 1 };
            int[] case3 = new int[] { 1, 1, 1, 1 };
            int[] case4 = new int[] { 0, 0, 0, 0 };
            int[] case5 = new int[] { 1, 2, 3, 2, 1 };
            int[] case6 = new int[] { 1, 3, 1, 3, 4, 4, 3, 2, 1, 5 };
            int[] case7 = new int[] { 5, 4, 7, 1, 2, 3 };
            int[] case8 = new int[] { 1, 2 };
            Assert.AreEqual(2, b.MaxProfit(case1));
            Assert.AreEqual(0, b.MaxProfit(case2));
            Assert.AreEqual(0, b.MaxProfit(case3));
            Assert.AreEqual(0, b.MaxProfit(case4));
            Assert.AreEqual(2, b.MaxProfit(case5));
            Assert.AreEqual(4, b.MaxProfit(case6));
            Assert.AreEqual(3, b.MaxProfit(case7));
            Assert.AreEqual(1, b.MaxProfit(case8));
        }

        [TestMethod]
        public void BestTimeToButAndSellII()
        {
            BestTimeToBuyAndSellII b = new BestTimeToBuyAndSellII();
            int[] case1 = new int[] { 1, 2, 3 };
            int[] case2 = new int[] { 3, 2, 1 };
            int[] case3 = new int[] { 1, 1, 1, 1 };
            int[] case4 = new int[] { 0, 0, 0, 0 };
            int[] case5 = new int[] { 1, 2, 3, 2, 1 };
            int[] case6 = new int[] { 1, 3, 1, 3, 4, 4, 3, 2, 1, 5 };
            int[] case7 = new int[] { 5, 4, 7, 1, 2, 3 };
            int[] case8 = new int[] { 1, 2 };
            Assert.AreEqual(2, b.MaxProfit(case1));
            Assert.AreEqual(0, b.MaxProfit(case2));
            Assert.AreEqual(0, b.MaxProfit(case3));
            Assert.AreEqual(0, b.MaxProfit(case4));
            Assert.AreEqual(2, b.MaxProfit(case5));
            Assert.AreEqual(9, b.MaxProfit(case6));
            Assert.AreEqual(5, b.MaxProfit(case7));
            Assert.AreEqual(1, b.MaxProfit(case8));
        }

        [TestMethod]
        public void BestTimeToButAndSellIII()
        {
            BestTimeToBuyAndSellIII b = new BestTimeToBuyAndSellIII();
            int[] case1 = new int[] { 1, 2, 3 };
            int[] case2 = new int[] { 3, 2, 1 };
            int[] case3 = new int[] { 1, 1, 1, 1 };
            int[] case4 = new int[] { 0, 0, 0, 0 };
            int[] case5 = new int[] { 1, 2, 3, 2, 1 };
            int[] case6 = new int[] { 1, 3, 1, 3, 4, 4, 3, 2, 1, 5 };
            int[] case7 = new int[] { 5, 4, 7, 1, 2, 3 };
            int[] case8 = new int[] { 1, 2 };
            int[] case9 = new int[] { 2, 5, 1, 1, 4 };
            int[] case10 = new int[] { 1, 2, 3, 2, 1, 2, 3 };

            Assert.AreEqual(2, b.MaxProfit(case1));
            Assert.AreEqual(0, b.MaxProfit(case2));
            Assert.AreEqual(0, b.MaxProfit(case3));
            Assert.AreEqual(0, b.MaxProfit(case4));
            Assert.AreEqual(2, b.MaxProfit(case5));
            Assert.AreEqual(7, b.MaxProfit(case6));
            Assert.AreEqual(5, b.MaxProfit(case7));
            Assert.AreEqual(1, b.MaxProfit(case8));
            Assert.AreEqual(6, b.MaxProfit(case9));
            Assert.AreEqual(4, b.MaxProfit(case10));
        }
    }
}
