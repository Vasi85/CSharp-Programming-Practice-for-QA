using System.Linq.Expressions;

namespace _01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == ' ')
                {
                    continue;
                }
                if (!characters.ContainsKey(currentChar))
                {
                    characters.Add(currentChar, 1);
                }
                else
                {
                    characters[currentChar]++;
                }
            }

            foreach (KeyValuePair<char, int> sym in characters)
            {
                Console.WriteLine($"{sym.Key} -> {sym.Value}");
            }
        }
    }
}