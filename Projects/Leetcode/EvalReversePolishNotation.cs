/*
 * Evaluate the value of an arithmetic expression in Reverse Polish Notation.

 * Valid operators are +, -, *, /. Each operand may be an integer or another expression.
 * 
 * Some examples:
 * 
 *   ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
 *   ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class EvalReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<string> Rpn = new Stack<string>();
            int n1, n2, result;
            foreach(string s in tokens)
            {
                if(int.TryParse(s, out n1)) // number
                {
                    Rpn.Push(s);
                }
                else // op
                {
                    if(Rpn.Count > 1)
                    {
                        int.TryParse(Rpn.Pop(), out n2);
                        int.TryParse(Rpn.Pop(), out n1);
                        Rpn.Push(GetResult(n1, n2, s).ToString());
                    }
                    else
                    {
                        throw new Exception("Stack underflow");
                    }
                }
            }

            if(Rpn.Count == 1)
            {
                int.TryParse(Rpn.Pop(), out result);
            }
            else
            {
                throw new Exception("Result count is not 1");
            }
            return result;
        }

        protected int GetResult(int n1, int n2, string op)
        {
            if (op.Equals("+")) return n1 + n2;
            else if (op.Equals("-")) return n1 - n2;
            else if (op.Equals("*")) return n1 * n2;
            else if (op.Equals("/")) return n1 / n2;
            else throw new Exception("Operator not valid");
        }
    }
}
