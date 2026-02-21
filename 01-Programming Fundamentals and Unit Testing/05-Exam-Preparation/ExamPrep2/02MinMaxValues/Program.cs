namespace _02MinMaxValues
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Read integer N
            int N = int.Parse(Console.ReadLine());

            // Extract the first N elements
            int[] firstNElements = numbers.Take(N).ToArray();

            // Find max and min in the first N elements
            int maxNumber = firstNElements.Max();
            int minNumber = firstNElements.Min();

            // Print results
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
        }*/
        static void Mains(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int N = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                int number = numbers[i];
                if (number > minNumber)
                {
                    minNumber = number;
                }
                if (number < maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.Write($"{maxNumber}, {minNumber}");
            
        }
    }
}