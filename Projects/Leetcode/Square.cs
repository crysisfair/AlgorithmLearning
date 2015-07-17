/*
 * Implement int sqrt(int x).
 * 
 * Compute and return the square root of 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Square
    {
        public int MySqrt(int x)
        {
            if (x < 0) return 0;
            else if (x == 1) return 1;
            int mid = 1;
            int low = 1;
            int high = x;
            int calc = 0;
            while(low <= high)
            {
                int temp = (high - low) >> 2;
                mid = low + temp;
                calc = x / mid;
                if(calc == mid)
                {
                    return mid;
                }
                else if(calc < mid)
                {
                    high = mid - 1;
                }
                else if(calc > mid)
                {
                    low = mid + 1;
                }
            }
            return high; // 返回的high值为小于或等于low值，即正好刚等于sqrt(x)向下取整
        }
    }
}
