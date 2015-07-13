/*
 * Given an array of non-negative integers, you are initially positioned at the first index of the array.
 * 
 * Each element in the array represents your maximum jump length at that position.
 * 
 * Determine if you are able to reach the last index.
 * 
 * For example:
 * A = [2,3,1,1,4], return true.
 * 
 * A = [3,2,1,0,4], return false. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class JumpGameTLE
    {
        void CheckNode(int currentIndex, int[] nums, ref bool canJump)
        {
            if (canJump == true) return;
            for(int i = 1; i <= nums[currentIndex]; i++)
            {
                if(currentIndex + i == nums.Length - 1)
                {
                    canJump = true;
                    return;
                }
                else if(currentIndex + i >= nums.Length)
                {
                    return;
                }
                else if(currentIndex + i < nums.Length - 1)
                {
                    CheckNode(currentIndex + i, nums, ref canJump);
                }
                else { return; }
            }
        }

        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1) return true;
            bool canJump = false;
            CheckNode(0, nums, ref canJump);
            return canJump;
        }
    }

    public class JumpGame
    {

        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1) return true;
            if (nums[0] >= nums.Length - 1) return true;
            int maxLength = nums[0];
            for(int i = 1; i< nums.Length; i ++)
            {
                if(maxLength < i)
                {
                    continue;
                }
                else if(maxLength >= i && i + nums[i] >= nums.Length - 1)
                {
                    return true;
                }
                else
                {
                    maxLength = Math.Max(i + nums[i], maxLength);
                    if (maxLength >= nums.Length - 1) return true;
                }
            }
            return false;
        }
    }

    public class JumpGameII
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1) return true;
            if (nums[0] >= nums.Length - 1) return true;
            int maxLength = nums[0];
            for(int i = 1; i< nums.Length; i ++)
            {
                if(maxLength < i)
                {
                    continue;
                }
                else if(maxLength >= i && i + nums[i] >= nums.Length - 1)
                {
                    return true;
                }
                else
                {
                    maxLength = Math.Max(i + nums[i], maxLength);
                    if (maxLength >= nums.Length - 1) return true;
                }
            }
            return false;
        }

        public int Jump(int[] nums)
        {
            if (CanJump(nums) == false) return 0;
            int lastMaxLength = 0;
            int currentMaxLength = 0;
            int steps = 0;
            if(nums.Length <= 1) return 0;
            if(nums[0] >= nums.Length - 1) return 1;
            List<int> stepsResult = new List<int>();
            for(int i = 0; i < nums.Length; ++i)
            {
                if (lastMaxLength < i && lastMaxLength < currentMaxLength && i <= currentMaxLength)
                {
                    steps += 1;
                    lastMaxLength = currentMaxLength;
                }
                currentMaxLength = Math.Max(currentMaxLength, i + nums[i]);
                if (currentMaxLength >= nums.Length - 1) stepsResult.Add(steps + 1);
            }
            int min = 0;
            if(stepsResult.Count > 0)
            {
                min = stepsResult[0];
                foreach(int s in stepsResult)
                {
                    min = Math.Min(min, s);
                }
            }
            return min;
        }
    }
}
