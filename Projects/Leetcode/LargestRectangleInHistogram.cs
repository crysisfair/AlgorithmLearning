/*
 * Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
 * 
 * 
 * Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].
 * 
 * 
 * The largest rectangle is shown in the shaded area, which has area = 10 unit.
 * 
 * For example,
 * Given height = [2,1,5,6,2,3],
 * return 10. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LargestRectangleInHistogram
    {
        public int LargestRectangleArea(int[] height)
        {
            int largestArea = 0;
            int area = 0;
            for(int i = 0; i < height.Length; i++)
            {
                for(int j = i + 1; j < height.Length; j++ )
                {
                    if (height[j] < height[j - 1])
                    {
                        i = j - 1;
                        break;
                    }
                    else i = j;
                }

                int lowest = height[i];
                for(int j = i; j >= 0; j-- )
                {
                    lowest = Math.Min(height[j], lowest);
                    area = lowest * (i - j + 1);
                    largestArea = Math.Max(area, largestArea);
                }
            }
            return largestArea;
        }
    }
}
