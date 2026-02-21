namespace _03Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            while (second.Contains(first))
            {
                int startIndex = second.IndexOf(first);

                second = second.Remove(startIndex, first.Length); 
            }
            Console.WriteLine(second);
        }
    }
}