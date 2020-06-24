using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetMiddleChar(text);
        }

        static void GetMiddleChar(string text)
        {
            int middle = (text.Length - 1) / 2;

            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{ text[middle]}{text[middle + 1]}");
            }
            else
            {
                Console.WriteLine(text[middle]);
            }
        }
    }
}
