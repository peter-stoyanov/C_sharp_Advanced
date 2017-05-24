using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            var inputString = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    stack.Push(i);
                }
                if (inputString[i] == ')')
                {
                    var startParenthesisIndex = stack.Pop();
                    var endParenthesisIndex = i;
                    Console.WriteLine(inputString.Substring(startParenthesisIndex, endParenthesisIndex - startParenthesisIndex + 1));
                }
            }
        }
    }
}
