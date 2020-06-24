using Microsoft.CSharp.RuntimeBinder;
using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            PrintBetwen(first , last);
        }

        static void PrintBetwen(char first , char last)
        {
            for (int i = (int)first; i <= (int)last; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
