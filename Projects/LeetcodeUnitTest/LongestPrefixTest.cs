using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class LongestPrefixTest
    {
        [TestMethod]
        public void LongestPrefixTestNormal()
        {
            LongestPrefix l = new LongestPrefix();
            string[] case2 = new string[] { "aaaaaa", "aaa", "aaaaaaaa", "aaaaaaaa", "aaaaaaaaaaaaaa", "aaaaaaaaaaaaaaa", "aaa", "aaaa"};
            Assert.AreEqual("aaa", l.LongestCommonPrefix(case2));
            string[] case1 = new string[] { "casetestok", "caset345", "caset", "caset3,.df", "caset", "casetldf"};
            Assert.AreEqual("caset", l.LongestCommonPrefix(case1));
        }
    }
}
