using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<Day>\d{2})([./-])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})";
            string dates = Console.ReadLine();

            MatchCollection validDate = Regex.Matches(dates, pattern);

            foreach (Match value in validDate)
            {
                string day = value.Groups["Day"].Value;
                string month = value.Groups["Month"].Value;
                string year = value.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}