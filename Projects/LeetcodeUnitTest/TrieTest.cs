using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;

namespace LeetcodeUnitTest
{
    [TestClass]
    public class TrieTest
    {
        [TestMethod]
        public void TestTrieWord()
        {
            Trie t = new Trie();
            t.Insert("hello");
            t.Insert("he");
            t.Insert("haw");
            t.Insert("match");
            t.Insert("yesterday");

            Assert.IsTrue(t.Search("he"));
            Assert.IsTrue(t.Search("haw"));
            Assert.IsFalse(t.Search("mated"));
            Assert.IsFalse(t.Search("matches"));
        }
    }
}
