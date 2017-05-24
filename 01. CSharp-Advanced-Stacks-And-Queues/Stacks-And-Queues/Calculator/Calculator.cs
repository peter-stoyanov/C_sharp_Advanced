using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            //2 - 2 + 5
            var inputArray = Console.ReadLine().Split().Reverse().ToList();

            var stack = new Stack<string>(inputArray);
            
            while (stack.Count > 1)
            {
                int firstNum, secondNnum;

                if (int.TryParse(stack.Pop(), out firstNum))
                {
                    var oper = stack.Pop().ToCharArray().First();

                    if (int.TryParse(stack.Pop(), out secondNnum))
                    {
                        int newNum;
                        switch (oper)
                        {
                            case '+':
                                newNum = firstNum + secondNnum;
                                stack.Push(newNum.ToString());
                                break;
                            case '-':
                                newNum = firstNum - secondNnum;
                                stack.Push(newNum.ToString());
                                break;
                        }
                    }
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
