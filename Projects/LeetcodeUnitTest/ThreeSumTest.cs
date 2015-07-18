using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class ThreeSumTest
    {
        bool CheckResult(List<List<int>> expt, List<IList<int>> actual)
        {
            if (expt.Count != actual.Count) return false;
            List<string> es = new List<string>();
            foreach(List<int> l in expt)
            {
                es.Add(String.Format("{0}{1}{2}", l[0], l[1], l[2]));
            }
            foreach(List<int> a in actual)
            {
                string r = String.Format("{0}{1}{2}", a[0], a[1], a[2]);
                if (!es.Contains(r)) return false;
            }
            return true;
        }

        [TestMethod]
        public void ThreeSumTestNormalCase()
        {
            int[] case1 = new int[] { -1, 0, 1, 2, -1, -4 };
            List<List<int>> case1Res = new List<List<int>>() { new List<int>() { -1, 0, 1 }, new List<int>() { -1, -1, 2 } };
            int[] case2 = new int[] { 0, 0, 0, 0 };
            List<List<int>> case2Res = new List<List<int>>() { new List<int>() { 0, 0, 0 }};
            int[] case3 = new int[] { -4, -2, -2, 0, 0, 0, 2, 2, 4 };
            List<List<int>> case3Res = new List<List<int>>() { new List<int>() {-4, 0, 4},
                new List<int>() {-2, 0, 2}, new List<int>() {-2, -2, 4}, new List<int>() {-4, 2, 2}, new List<int>() {0, 0, 0}};
            int[] case4 = new int[] {2,0,-3,-2,3,-1,-3,0,1,0,3,4,-5,2 };
            List<List<int>> case4Res = new List<List<int>>() { new List<int>() {-5, 1, 4}, new List<int>() {-5, 2,3 }, 
                new List<int>() {-3, -1, 4}, new List<int>() {-3, 0, 3}, new List<int>() {-3, 1, 2},new List<int>() {-2, -1, 3},
                new List<int>() {-2, 0, 2}, new List<int>() {-1, 0, 1}, new List<int>() {0, 0, 0}};
            
            ThreeSumCalc t = new ThreeSumCalc();
            Assert.IsTrue(CheckResult(case1Res, (List<IList<int>>)t.ThreeSum(case1)));
            Assert.IsTrue(CheckResult(case2Res, (List<IList<int>>)t.ThreeSum(case2)));
            Assert.IsTrue(CheckResult(case3Res, (List<IList<int>>)t.ThreeSum(case3)));
            Assert.IsTrue(CheckResult(case4Res, (List<IList<int>>)t.ThreeSum(case4)));
        }
    }
}
