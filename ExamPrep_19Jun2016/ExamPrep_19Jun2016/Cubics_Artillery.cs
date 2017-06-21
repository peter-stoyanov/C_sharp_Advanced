using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep_19Jun2016
{
    class Cubics_Artillery
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bunkersQueue = new Queue<char>();
            var storedWeaponsQueue = new Queue<int>();
            int capacity = n;
            int weaponsToStore = 0;
            int currentWeapon = 0;

            foreach (var token in tokens)
            {
                if (IsChar(token))
                {
                    bunkersQueue.Enqueue(token.ToCharArray()[0]);
                }
                else
                {
                    currentWeapon = int.Parse(token);
                    weaponsToStore += currentWeapon;
                }

                if (capacity > weaponsToStore)
                {
                    storedWeaponsQueue.Enqueue(currentWeapon);
                    capacity -= currentWeapon;
                }
                else if (capacity == weaponsToStore)
                {
                    Console.WriteLine($"{bunkersQueue.Dequeue()} -> {String.Join(", ", storedWeaponsQueue)}");
                    storedWeaponsQueue.Clear();
                    capacity = 0;
                }
                else
                {
                    //capacity is lower -> must pass the weapons forward until resolving ???
                }

            }
        }

        private static bool IsChar(string token)
        {
            var charArr = token.ToCharArray();
            return charArr.Length == 1 && Char.IsLetter(charArr[0]);
        }
    }
}
