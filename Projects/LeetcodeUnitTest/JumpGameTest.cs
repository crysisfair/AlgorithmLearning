using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class JumpGameTest
    {
        [TestMethod]
        public void JumpGameTestNormalCase()
        {
            // JumpGameTLE g = new JumpGameTLE();
            JumpGame g = new JumpGame();
            int[] case1 = new int[] { 2, 3, 1, 1, 4 };
            Assert.AreEqual(true, g.CanJump(case1));
            int[] case2 = new int[] { 0, 3, 1, 0, 4 };
            Assert.AreEqual(false, g.CanJump(case2));
            int[] case3 = new int[] { 3, 2, 1, 0, 4 };
            Assert.AreEqual(false, g.CanJump(case3));
            int[] case4 = new int[] { 0, 0, 0, 0, 0 };
            Assert.AreEqual(false, g.CanJump(case4));
            int[] case5 = new int[] { 1, 0, 1, 0};
            Assert.AreEqual(false, g.CanJump(case5));
            int[] case6 = new int[] { 2, 2, 2, 2, 2 };
            Assert.AreEqual(true, g.CanJump(case6));
            int[] case7 = new int[] { 2, 5, 0, 0, 0, 0 };
            Assert.AreEqual(true, g.CanJump(case7));
            int[] case8 = new int[] { 1, 1, 2, 2, 0, 1, 1 };
            Assert.AreEqual(true, g.CanJump(case8));
            int[] case9 = new int[] { 1, 2, 3};
            Assert.AreEqual(true, g.CanJump(case9));
            int[] case10 = new int[] { 1, 0, 3};
            Assert.AreEqual(false, g.CanJump(case10));
        }

        [TestMethod]
        public void JumpGameIITest()
        {
            JumpGameII g = new JumpGameII();
            int[] case1 = new int[] { 2, 3, 1, 1, 4 };
            Assert.AreEqual(2, g.Jump(case1));
            int[] case2 = new int[] { 0, 3, 1, 0, 4 };
            Assert.AreEqual(0, g.Jump(case2));
            int[] case3 = new int[] { 3, 2, 1, 0, 4 };
            Assert.AreEqual(0, g.Jump(case3));
            int[] case4 = new int[] { 0, 0, 0, 0, 0 };
            Assert.AreEqual(0, g.Jump(case4));
            int[] case5 = new int[] { 1, 0, 1, 0};
            Assert.AreEqual(0, g.Jump(case5));
            int[] case6 = new int[] { 2, 2, 2, 2, 2 };
            Assert.AreEqual(2, g.Jump(case6));
            int[] case7 = new int[] { 2, 5, 0, 0, 0, 0 };
            Assert.AreEqual(2, g.Jump(case7));
            int[] case8 = new int[] { 1, 1, 2, 2, 0, 1, 1 };
            Assert.AreEqual(5, g.Jump(case8));
            int[] case9 = new int[] { 1, 2, 3};
            Assert.AreEqual(2, g.Jump(case9));
            int[] case10 = new int[] { 1, 0, 3};
            Assert.AreEqual(0, g.Jump(case10));
            int[] case11 = new int[] { 0 };
            Assert.AreEqual(0, g.Jump(case11));
        }
    }
}
