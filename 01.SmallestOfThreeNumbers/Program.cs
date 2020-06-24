using System;
using System.ComponentModel.DataAnnotations;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(first , second ,third));
        }

        static int GetSmallestNumber(int first, int second, int third)
        {
            int minNumber = int.MaxValue;
            int[] numbers = { first, second, third };
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }
    }
}
