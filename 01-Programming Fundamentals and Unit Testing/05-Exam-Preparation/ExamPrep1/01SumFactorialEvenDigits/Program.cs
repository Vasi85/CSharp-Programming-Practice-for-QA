namespace _01SumFactorialEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumEvenDigits = 0;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit %2  == 0)
                {
                    sumEvenDigits += Factorial(digit);
                }
                num /= 10;
            }

            Console.WriteLine(sumEvenDigits);
        }

        static int Factorial(int n) // n = 5
        {
            int result = 1;
            if (n == 0 || n == 1)
            {
                return result;
            }

            for (int i = n; i >= 2; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}