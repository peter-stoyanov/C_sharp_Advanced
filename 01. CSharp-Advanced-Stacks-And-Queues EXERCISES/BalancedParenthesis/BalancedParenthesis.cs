using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            // {[()]}

            var brackets = Console.ReadLine().ToCharArray();

            var stack = new Stack<char>();

            bool balanced = true;

            for (int i = 0; i < brackets.Length; i++)
            {
                switch (brackets[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(brackets[i]);
                        break;
                    case ')':
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            balanced = false;
                        }
                        break;
                    case '}':
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            balanced = false;
                        }
                        break;
                    case ']':
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            balanced = false;
                        }
                        break;
                }
            }

            Console.WriteLine(balanced ? "YES" : "NO");
        }
    }
}
