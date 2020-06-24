using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double firstFac = GetFactorial(first);
            double secondFac = GetFactorial(second);
            double total = firstFac / secondFac;
            Console.WriteLine($"{total:f2}");
        }

        static double GetFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number--;
            }
            return result;
        }

    }
}
