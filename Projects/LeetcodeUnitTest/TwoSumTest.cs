using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class TwoSumTest
    {
        bool CheckResult(int[] expt, int[] actual)
        {
            if (expt[0] == actual[0] && expt[1] == actual[1]) return true;
            return false;
        }

        [TestMethod]
        public void TwoSumTestNormalCase()
        {
            CalcTwoSum t = new CalcTwoSum();
            int[] case1 = new int[] { 7, 11, 15, 2 };
            int target1 = 9;
            int[] case1Res = new int[] { 1, 4 };
            int[] case2 = new int[] { 2, 7, 0, 15 };
            int target2 = 7;
            int[] case2Res = new int[] { 2, 3 };
            int[] case3 = new int[] { 2, 0, 0, 15 };
            int target3 = 0;
            int[] case3Res = new int[] { 2, 3 };
            Assert.IsTrue(CheckResult(case1Res, t.TwoSum(case1, target1)));
            Assert.IsTrue(CheckResult(case2Res, t.TwoSum(case2, target2)));
            Assert.IsTrue(CheckResult(case3Res, t.TwoSum(case3, target3)));
        }
    }
}
