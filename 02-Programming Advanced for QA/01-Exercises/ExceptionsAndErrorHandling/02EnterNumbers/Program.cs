namespace _02EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int start = 1;

            while (numbers.Count < 10)
            {
                try
                {
                    int currentNum = ReadNumber(start, 100);
                    numbers.Add(currentNum);
                    start = currentNum;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid Number!");
                }
            }
            Console.WriteLine(string.Join(", ", numbers.ToArray()));




            int ReadNumber(int start, int end)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= start || num >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return num;
            }


        }
    }
}
