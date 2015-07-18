/*
 * Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
 * 
 * Note:
 * 
 *     Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ≤ b ≤ c)
 *     The solution set must not contain duplicate triplets.
 * 
 *     For example, given array S = {-1 0 1 2 -1 -4},
 * 
 *     A solution set is:
 *     (-1, 0, 1)
 *     (-1, -1, 2)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ThreeSumCalc
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (nums.Length < 3) return res;
            List<int> ns = new List<int>();
            ns.AddRange(nums);
            ns.Sort();
            int lastNumber = 0;
            int lastJNumber = 0;
            bool hasJNumber = false;
            int sum = 0;
            for(int i = 0; i <= ns.Count - 2 && ns[i] <= 0; i++)
            {
                if (i != 0 && lastNumber == ns[i])
                    continue;
                int j = i + 1, k = ns.Count - 1;
                while(j < k)
                {
                    if(hasJNumber && lastJNumber == ns[j])
                    {
                        j += 1;
                    }
                    else
                    {
                        hasJNumber = false;
                        sum = ns[i] + ns[j] + ns[k];
                        if (sum < 0) j += 1;
                        else if (sum > 0) k -= 1;
                        else
                        {
                            res.Add(new List<int>() { ns[i], ns[j], ns[k] });
                            lastJNumber = ns[j];
                            hasJNumber = true;
                            j += 1;
                        }
                    }
                }
                hasJNumber = false;
                lastNumber = ns[i];
            }
            return res;
        }
    }
}
