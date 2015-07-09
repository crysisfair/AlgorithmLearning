/*
 * Given a string s and a dictionary of words dict, add spaces in s to construct a sentence where each word is a valid dictionary word.
 * 
 * Return all such possible sentences.
 * 
 * For example, given
 * s = "catsanddog",
 * dict = ["cat", "cats", "and", "sand", "dog"].
 * 
 * A solution is ["cats and dog", "cat sand dog"]. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class WordBreakII
    {

        public IList<string> WordBreak(string s, ISet<string> wordDict)
        {
            // 首先确认s可以break
            // 状态转移方程： d(i)= 存在j使得 d(j) && s.SubString(i, i -j) 在 wordDict中
            // dps[i] 表示 从s.SubString(0, i)是否是可以break的
            List<bool> dps = new List<bool>();
            for(int i = 0; i <= s.Length; i++)
            {
                dps.Add(false);
            }
            dps[0] = true;

            for(int i = 0; i < s.Length; ++i)
            {
                if(dps[i])
                {
                    for(int j = 1; i + j < s.Length + 1; ++j)
                    {
                        if(wordDict.Contains(s.Substring(i, j)))
                        {
                            dps[i + j] = true;
                        }
                    }
                }
            }

            List<string> solutions = new List<string>();

            if(dps[s.Length])
            {
                Break(solutions, 0, dps, s, wordDict, ""); 
            }
            return solutions;
        }

        void Break(List<string> solutions, int index,  List<bool> dps, string s, ISet<string> dict, string result_str)
        {
            for (int len = 1; index + len < s.Length + 1; ++len )
            {
                if (dps[index + len] && dict.Contains(s.Substring(index, len)))
                {
                    string subStr = s.Substring(index, len);
                    if (index + len < s.Length)
                    {
                        Break(solutions, index + len, dps, s, dict, result_str + subStr + " ");// 重要，这里只能进行值传递
                    }
                    else
                    {
                        solutions.Add(result_str + subStr);
                        return;
                    }
                }
            }
        }
    }
}
