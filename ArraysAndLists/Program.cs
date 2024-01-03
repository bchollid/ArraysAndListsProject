using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();

            var odds = new List<int>();

            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            evens.ForEach(Console.WriteLine);
            for(var i = 0; i<odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
