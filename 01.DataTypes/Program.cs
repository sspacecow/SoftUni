using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(Calculation(input));

            }
            else if (type == "string")
            {
                string input = Console.ReadLine();
                Calculation(input);
            }
            else if (type == "real")
            {
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Calculation(input):f2}");
            }
        }

        static int Calculation(int number)
        {
            number = number * 2;
            return number;
        }

        static void Calculation(string text)
        {
            Console.WriteLine($"${text}$");
        }

        static double Calculation(double number)
        {
            number = number * 1.5;
            return number;
        }
    }
}
