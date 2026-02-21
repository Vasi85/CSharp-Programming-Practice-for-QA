namespace _02AverageSalesInSelectedRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dailySalesAmounts = Console.ReadLine()
                                             .Split(' ')
                                             .Select(int.Parse)
                                             .ToArray();

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            double sumSales = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                sumSales += dailySalesAmounts[i];
            }

            double average = sumSales / (endIndex - startIndex + 1);

            Console.WriteLine($"{average:F2}");
        }
    }
}