using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System.Collections.Generic;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class WordBreakIITest
    {
        bool isListEqual(List<string> l1, List<string> l2)
        {
            if (l1.Count != l2.Count) return false;
            foreach(string s in l1)
            {
                if (!l2.Contains(s)) return false;
            }
            return true;
        }

        [TestMethod]
        public void WORdBreakIITestExample()
        {
            WordBreakII wb = new WordBreakII();
            SortedSet<string> wordset = new SortedSet<string>();
            wordset.Add("cat");
            wordset.Add("cats");
            wordset.Add("and");
            wordset.Add("sand");
            wordset.Add("dog");
            List<string> strs = (List<string>)wb.WordBreak("catsanddog", wordset);
            List<string> target = new List<string>(){"cats and dog", "cat sand dog"};
            Assert.IsTrue(isListEqual(target, strs));
        }

        [TestMethod]
        public void WORdBreakIITestErrorCase()
        {
            WordBreakII wb = new WordBreakII();
            SortedSet<string> wordset = new SortedSet<string>();
            wordset.Add("aaaa");
            wordset.Add("aaa");
            List<string> strs = (List<string>)wb.WordBreak("aaaaaaa", wordset);
            List<string> target = new List<string>() { "aaaa aaa", "aaa aaaa" };
            Assert.IsTrue(isListEqual(target, strs));
        }
    }
}
