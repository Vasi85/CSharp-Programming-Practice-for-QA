namespace _02AverageAndTotalRainfall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dailyRainfallAmounts = Console.ReadLine()
                                                .Split(' ')
                                                .Select(int.Parse)
                                                .ToArray();

            int startDay = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = startDay; i <= endDay; i++)
            {
                total += dailyRainfallAmounts[i];
            }
            Console.WriteLine(total);

            double averageRainfall = total / (endDay - startDay + 1);
            Console.WriteLine($"{averageRainfall:F2}");
        }
    }
}