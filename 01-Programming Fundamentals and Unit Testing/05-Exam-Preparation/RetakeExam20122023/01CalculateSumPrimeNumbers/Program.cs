namespace _01CalculateSumPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                int numValue = int.Parse(Console.ReadLine());
                if (IsPrime(numValue))
                {
                    sum += numValue;

                }

            }
            Console.WriteLine(sum);

        }
        static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i ==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}