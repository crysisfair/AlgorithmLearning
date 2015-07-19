/*
 * Given an array of integers, find two numbers such that they add up to a specific target number.

 * The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
 * 
 * You may assume that each input would have exactly one solution.
 * 
 * Input: numbers={2, 7, 11, 15}, target=9
 * Output: index1=1, index2=2 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CalcTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length <= 1) return new int[] { 0, 0 };
            Dictionary<int, List<int>> t = new Dictionary<int, List<int>>();
            List<int> ns = new List<int>();
            ns.AddRange(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if(t.ContainsKey(nums[i]))
                {
                    t[nums[i]].Add(i + 1);
                }
                else
                {
                    t.Add(nums[i], new List<int>() { i + 1 });
                }
            }
            ns.Sort();
            int calc = 0;
            for(int i = 0; i < ns.Count; i++ )
            {
                int j = i + 1;
                while( j < ns.Count)
                {
                    calc = ns[i] + ns[j];
                    if(calc < target)
                    {
                        j += 1;
                    }
                    else if(calc == target)
                    {
                        int index1;
                        int index2;
                        if(ns[i] == ns[j])
                        {
                            index1 = t[ns[i]][0];
                            index2 = t[ns[j]][1];
                        }
                        else
                        {
                            index1 = t[ns[i]][0];
                            index2 = t[ns[j]][0];
                        }
                        if(index1 > index2)
                        {
                            return new int[] { index2, index1 };
                        }
                        return new int[] { index1, index2 };
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return new int[2] { 0, 0 };
        }
    }
}
