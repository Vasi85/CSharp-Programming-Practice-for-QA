using System.Diagnostics.Metrics;

namespace _01CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (int num in nums)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers[num] = 1;
                }
            }
            foreach (KeyValuePair<int, int> numPair in numbers)
            {
                Console.WriteLine($"{numPair.Key} -> {numPair.Value}");
            }
        }
    }
}