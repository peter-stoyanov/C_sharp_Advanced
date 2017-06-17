using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5
            //add + 1 
            //multiply * 2
            //subtract - 1
            //print
            //end
            var commandList = new List<string>();

            Action<int[]> printer = (arr) => Console.WriteLine(String.Join(" ", arr));

            Func<int[], string, int[]> arithmeticApplicator = (arr, comm) =>
            {
                switch (comm)
                {
                    case "add":
                    arr =  arr.Select(x => x + 1).ToArray();
                        break;
                    case "subtract":
                        arr = arr.Select(x => x - 1).ToArray();
                        break;
                    case "multiply":
                        arr = arr.Select(x => x * 2).ToArray();
                        break;
                };
                return arr;
            };


            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                commandList.Add(command);
            }

            foreach (var comm in commandList)
            {
                if (comm == "print")
                {
                    printer(inputArr);
                }
                else
                {
                    inputArr = arithmeticApplicator(inputArr, comm);
                }
            }

        }
    }
}
