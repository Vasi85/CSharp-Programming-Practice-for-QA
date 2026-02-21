namespace _02SmallerNumbers
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

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] < N)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            
        }
    }
}