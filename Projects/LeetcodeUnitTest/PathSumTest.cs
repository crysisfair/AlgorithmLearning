using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class PathSumTest
    {
        [TestMethod]
        public void PathSumTestNormalCase()
        {
            PathSum p = new PathSum();
            /* 
             *           5
             *         /     \
             *       4        8
             *     /  \      /  \
             *   11    0    13    4
             *  /  \ /  \  /  \ /  \
             * 7   2 0  0 0   0 0  1
             */
            int[] case1 = new int[] { 5, 4, 8, 11, 0, 13, 4, 7, 2, 0, 0, 0, 0, 0, 1 };
            PathSum.TreeNode tree1 = new PathSum.TreeNode(5, 0);
            p.GenerateTree(case1, ref tree1);
            Assert.AreEqual(true, p.HasPathSum(tree1, 22));
        }
    }
}
