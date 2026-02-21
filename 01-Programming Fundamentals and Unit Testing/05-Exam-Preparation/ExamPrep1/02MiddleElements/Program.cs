namespace _02MiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                                    .Split(" ")
                                    .Select(int.Parse)
                                    .ToArray();

            int mid = numArray.Length / 2;
            double result = 0;

            for (int i = mid - 1; i <= mid; i++)
            {
                result += numArray[i];
            }

            double divisionMid = result / 2;

            Console.WriteLine($"{divisionMid:F2}");
        }
    }
}