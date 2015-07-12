using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            List<char> chars = new List<char>();
            if(strs.Count<string>() > 0)
            {
                chars.AddRange(strs[0].ToCharArray());
            }
            bool notAllowAdd = false;
            for(int s = 1; s < strs.Length; s++ )
            {
                char[] strChars = strs[s].ToCharArray();
                if(strChars.Length < chars.Count)
                {
                    chars.RemoveRange(strChars.Length, chars.Count - strChars.Length);
                    notAllowAdd = true;
                }
                for(int i = 0; i < strs[s].Length; i++ )
                {
                    if (i >= chars.Count) break;
                    else if(strChars[i] != chars[i])
                    {
                        chars.RemoveRange(i, chars.Count - i);
                        notAllowAdd = true;
                        break;
                    }
                    else if (strChars[i] == chars[i]) continue;
                    else if(notAllowAdd == false)
                    {
                        chars.Add(strChars[i]);
                    }
                    else { break; }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in chars) sb.Append(c);
            return sb.ToString();
        }
    }
}
