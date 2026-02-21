using System.Diagnostics.Tracing;

namespace _02RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(" ");

            string concatenated = "";

            foreach (string word in inputArray)
            {
                int repeat = word.Length;
                for (int i = 1; i <= word.Length; i++)
                {
                    concatenated += word;
                }
            }
            Console.WriteLine(concatenated);
        }
    }
}