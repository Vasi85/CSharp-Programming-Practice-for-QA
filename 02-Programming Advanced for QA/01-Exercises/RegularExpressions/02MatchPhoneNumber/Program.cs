using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            string phoneNum = Console.ReadLine();

            MatchCollection number = Regex.Matches(phoneNum, pattern);

            Console.WriteLine(string.Join(", ", number));
        }
    }
}