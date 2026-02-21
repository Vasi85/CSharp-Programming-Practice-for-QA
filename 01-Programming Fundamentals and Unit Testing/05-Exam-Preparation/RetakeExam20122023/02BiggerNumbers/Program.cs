namespace _02BiggerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            int N = int.Parse(Console.ReadLine());

            foreach (int num in numbers)
            {
                if (num > N)
                {
                    Console.Write(num + " ");
                }
            }
            
        }
    }
}