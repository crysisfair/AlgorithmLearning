using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEvalRPN()
        {
            EvalReversePolishNotation rpn = new EvalReversePolishNotation();
            Assert.AreEqual(rpn.EvalRPN(new string[] { "2", "1", "+", "3", "*" }), 9);
            Assert.AreEqual(rpn.EvalRPN(new string[] { "4", "13", "5", "/", "+" }), 6);
        }
    }
}
