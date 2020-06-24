using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            FindClosestToZero(x, y, x2, y2);
        }

        static void FindClosestToZero(int x, int y, int x2, int y2)
        {
            int sumFirst = x + y;
            int sumSecond = x + x2;

            int result = sumFirst.CompareTo(sumSecond);

            if (result > 0)
            {
                Console.WriteLine($"({x2},{y2})");
            }
            else if (result < 0)
            {
                Console.WriteLine($"{x},{y}");
            }
            else
            {
                Console.WriteLine($"{x},{y}");
            }
        }
    }
}
