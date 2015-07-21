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
            PathSumLinkList l = new PathSumLinkList();
            /* 
             *           5
             *         /     \
             *       4        8
             *     /         /  \
             *   11         13    4
             *  /  \               \
             * 7   2               1
             */
            int[] case1 = new int[] { 5, 4, 8, 11, 0, 13, 4, 7, 2, -1, -1, -1, -1, -1, 1 };
            PathSumLinkList.TreeNode tree1 = new PathSumLinkList.TreeNode(5, 0);
            l.GenerateTree(case1, ref tree1);
            /* 
             *           0
             *         /     \
             *       0        8
             *     /         /  \
             *   11         13    4
             */
            int[] case2 = new int[] { 0, 0, 8, 11, 0, 13, 4 };
            PathSumLinkList.TreeNode tree2 = new PathSumLinkList.TreeNode(0, 0);
            l.GenerateTree(case2, ref tree2);
            /* 
             *           1
             *         / 
             *       2 
             */
            int[] case3 = new int[] { 1, 2 };
            PathSumLinkList.TreeNode tree3 = new PathSumLinkList.TreeNode(1, 0);
            l.GenerateTree(case3, ref tree3);
            Assert.AreEqual(true, p.HasPathSum(tree1, 22));
            Assert.AreEqual(false, p.HasPathSum(tree1, 9));
            Assert.AreEqual(false, p.HasPathSum(tree1, 20));
            Assert.AreEqual(false, p.HasPathSum(tree1, 25));
            Assert.AreEqual(true, p.HasPathSum(tree2, 0));
            Assert.AreEqual(true, p.HasPathSum(tree2, 11));
            Assert.AreEqual(true, p.HasPathSum(tree2, 21));
            Assert.AreEqual(false, p.HasPathSum(tree2, 5));
            Assert.AreEqual(true, p.HasPathSum(tree3, 3));
        }
    }
}
