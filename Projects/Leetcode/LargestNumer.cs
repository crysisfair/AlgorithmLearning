/*
 * Largest Number Total Accepted: 23384 Total Submissions: 147764

 * Given a list of non negative integers, arrange them such that they form the largest number.
 * 
 * For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.
 * 
 * Note: The result may be very large, so you need to return a string instead of an integer.
 * 
 * Credits:
 * Special thanks to @ts for adding this problem and creating all test cases.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LargestNumer
    {

        bool HasLargerString(string sub)
        {
            foreach(string s in strs)
            {
                if (CompareNums(s, sub) > 0) return true;
            }
            return false;
        }
        void quick_sort(int l, int r)
        {
            if(l < r)
            {
                int i = l, j = r;
                string x = strs[l];
                while(i < j)
                {
                    while (i < j && CompareNums(strs[j], x) <= 0) // Reverse sort
                        j--;
                    if (i < j)
                        strs[i++] = strs[j];

                    while (i < j && CompareNums(strs[i], x) > 0)
                        i++;
                    if (i < j)
                        strs[j--] = strs[i];
                }
                strs[i] = x;
                quick_sort(l, i - 1);
                quick_sort(i + 1, r);
            }
        }
        List<string> strs = new List<string>();

        int CompareNums(string x, string y)
        {
            char[] xChars = x.ToCharArray();
            char[] yChars = y.ToCharArray();
            int temp = 0;
            for(int i = 0, j = 0; i < x.Length && j < y.Length; i++, j++)
            {
                temp = xChars[i] - yChars[j];
                if(temp != 0)
                {
                    return temp;
                }
            }
            if (x.Length > y.Length)
            {
                return CompareNums(x.Substring(y.Length, x.Length - y.Length), y);
            }
            else if (y.Length > x.Length)
            {
                return CompareNums(x, y.Substring(x.Length, y.Length - x.Length));
            }
            return temp;
        }

        public string LargestNumber(int[] nums)
        {
            if (nums.Length == 0) return "";
            else if (nums.Length == 1) return nums[0].ToString();
            foreach(int n in nums)
            {
                strs.Add(n.ToString());
            }
            // quick_sort(0, nums.Length - 1);
            strs.Sort(CompareNums);
            StringBuilder sb = new StringBuilder();
            int temp = 0;
            int.TryParse(strs[strs.Count - 1], out temp);
            if (temp == 0)
            {
                strs.Clear();
                return "0";
            }
            for (int i = strs.Count - 1; i >= 0; i-- )
            {
                sb.Append(strs[i]);
            }
            strs.Clear();
            return sb.ToString();
        }
    }
}
