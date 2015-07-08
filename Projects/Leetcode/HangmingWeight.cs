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
