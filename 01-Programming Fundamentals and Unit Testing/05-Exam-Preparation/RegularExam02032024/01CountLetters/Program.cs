namespace _01CountLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();

        int countLowerLetter = 0;
        int countUpperLetter = 0;
        int countSingleSpase = 0;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    countUpperLetter++;
                }
                else if (char.IsLower(c))
                {
                    countLowerLetter++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    countSingleSpase++;
                }
            }
            Console.WriteLine(countUpperLetter);
            Console.WriteLine(countLowerLetter);
            Console.WriteLine(countSingleSpase);
        }
    }
}