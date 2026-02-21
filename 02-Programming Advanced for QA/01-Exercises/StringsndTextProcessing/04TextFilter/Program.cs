namespace _04TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            
            foreach (var stringToRemove in bannedWords)
            {
                if (text.Contains(stringToRemove))
                {
                    text = text.Replace(stringToRemove, new string('*', stringToRemove.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}