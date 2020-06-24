using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = Add(first, second);
            int total = Subtract(sum, third);
            Console.WriteLine(total);

        }

        static int Add(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        static int Subtract(int sum , int third)
        {
            int newSum = sum - third;
            return newSum;
        }
    }
}
