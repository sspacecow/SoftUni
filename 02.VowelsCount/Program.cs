using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetVowelCount(text));
        }

        private static int GetVowelCount(string text)
        {
            int VowelCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'A' || text[i] == 'e' || text[i] == 'E' || text[i] == 'i' || text[i] == 'I'
                    || text[i] == 'O' || text[i] == 'o' || text[i] == 'u' || text[i] == 'U')
                {
                    VowelCount++;
                }
            }
            return VowelCount;
        }
    }
}
