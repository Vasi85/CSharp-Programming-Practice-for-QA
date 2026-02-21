using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection validFullNames = Regex.Matches(names, pattern);

            foreach (Match name in validFullNames)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}