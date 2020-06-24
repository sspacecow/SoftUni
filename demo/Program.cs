using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 4, 5, 6, 4, 7, 8 };
            Console.WriteLine(string.Join(" ", numbers));
            List<int> numbers1 = new List<int>();
            numbers1.AddRange(numbers);
            Console.WriteLine(string.Join(" ",numbers1));
            numbers.Reverse();
            Console.WriteLine(string.Join(" ",numbers));
            numbers1.Sort();
            numbers1.Reverse();
            Console.WriteLine(string.Join(" ",numbers1));
        }
    }
}
