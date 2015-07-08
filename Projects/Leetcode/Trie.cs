using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class TrieNode
    {
        public TrieNode[] ChildNodes;

        public char NodeChar;

        /// <summary>
        /// 经过该节点的路径数目，对应于前缀匹配数
        /// </summary>
        public int Paths = 0;

        /// <summary>
        /// 最终在该节点结束的路径数目，对应于词频
        /// </summary>
        public int Frequence = 0;        

        // Initialize your data structure here.
        public TrieNode()
        {
            //假设是26个字母，全是小写
            ChildNodes = new TrieNode[26];
        }

        public void InsertChilds(String word)
        {
            if (word.Length < 0) return;

            int childPosi = 0;
            TrieNode currentNode = this;
            int count = 0;
            foreach(char c in word.ToCharArray())
            {
                childPosi = c - 'a';
                if(currentNode.ChildNodes[childPosi] == null)
                {
                    currentNode.ChildNodes[childPosi] = new TrieNode();
                    currentNode.ChildNodes[childPosi].NodeChar = c;
                }
                currentNode.ChildNodes[childPosi].Paths += 1;
                count += 1;
                if (count == word.Length) currentNode.ChildNodes[childPosi].Frequence += 1;

                //将指针指向下一个字母的节点
                currentNode = currentNode.ChildNodes[childPosi];
            }
        }

        public SearchResult SearchNodePath(String word)
        {
            if (word.Length < 0) return SearchResult.NoMatches;

            TrieNode currentNode = this;
            int childPosi = 0;
            foreach(char c in word.ToCharArray())
            {
                childPosi = c - 'a';
                if(currentNode.ChildNodes[childPosi] == null)
                {
                    return SearchResult.NoMatches;
                }
                currentNode = currentNode.ChildNodes[childPosi];
            }

            if (currentNode.Frequence > 0) return SearchResult.TotalMatch;

            return SearchResult.PrefixMatch;
        }
    }

    public enum SearchResult
    {
        NoMatches,
        TotalMatch,
        PrefixMatch,
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void Insert(String word)
        {
            root.InsertChilds(word);
        }

        // Returns if the word is in the trie.
        public bool Search(string word)
        {
            SearchResult result = root.SearchNodePath(word);
            if (result == SearchResult.TotalMatch) return true;
            return false;
        }

        // Returns if there is any word in the trie
        // that starts with the given prefix.
        public bool StartsWith(string word)
        {
            SearchResult result = root.SearchNodePath(word);
            if (result == SearchResult.NoMatches) return false;
            return true;
        }
    }

    // Your Trie object will be instantiated and called as such:
    // Trie trie = new Trie();
    // trie.Insert("somestring");
    // trie.Search("key");
}
