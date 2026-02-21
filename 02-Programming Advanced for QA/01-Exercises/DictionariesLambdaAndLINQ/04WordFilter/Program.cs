namespace _04WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(' ')
                                    .Where(i => i.Length % 2 == 0)
                                    .ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}