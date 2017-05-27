using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            //IN, CA2844AA
            //or var input = Regex.Split(input, ", ");
            var input = Console.ReadLine().Split(new char[] { ',',' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var set = new SortedSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    set.Add(input[1]);
                }
                else
                {
                    set.Remove(input[1]);
                }

                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(String.Join("\n", set));
            }
        }
    }
}
