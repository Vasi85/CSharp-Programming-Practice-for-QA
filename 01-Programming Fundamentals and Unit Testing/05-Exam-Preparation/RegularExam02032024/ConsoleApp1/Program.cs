namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            int startIndex = int.Parse(Console.ReadLine());

            int endIndex = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = startIndex; i <= endIndex; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            int sum = maxNumber + minNumber;
            Console.WriteLine(sum.ToString());
        }
    }
}