/*
 * Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).
 * 
 * For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.
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
    class HangmingWeight
    {

        public int HammingWeight(uint n)
        {
            string binStr = Convert.ToString(n, 2);
            char[] bits = binStr.ToCharArray();
            List<int> bitsNum = new List<int>();
            foreach (char b in bits)
            {
                bitsNum.Add(int.Parse(b.ToString()));
            }
            int result = 0;
            foreach (int num in bitsNum)
            {
                result += num;
            }
            return result;
        }
    }
}
