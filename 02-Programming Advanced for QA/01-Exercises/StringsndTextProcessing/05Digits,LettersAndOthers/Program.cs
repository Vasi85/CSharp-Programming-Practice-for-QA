namespace _05Digits_LettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = "";
            string letters = "";
            string charachers = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else
                {
                    charachers += input[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(charachers);
        }
    }
}