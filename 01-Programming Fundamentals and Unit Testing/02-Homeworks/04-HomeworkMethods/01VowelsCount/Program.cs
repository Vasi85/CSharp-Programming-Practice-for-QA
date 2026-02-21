namespace _01VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelCount = PrintCountOfVowels(text);
            Console.WriteLine(vowelCount);


            static int PrintCountOfVowels(string text)
            {
                int count = 0;

                foreach (char letter in text)
                {
                    if (letter == 'a' ||
                        letter == 'o' ||
                        letter == 'e' ||
                        letter == 'u' ||
                        letter == 'i' ||
                        letter == 'A' ||
                        letter == 'O' ||
                        letter == 'E' ||
                        letter == 'U' ||
                        letter == 'I')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}