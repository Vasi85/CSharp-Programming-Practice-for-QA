using System.Security.Cryptography;

namespace _05MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int num = Math.Abs(int.Parse(Console.ReadLine()));


            int multiplication = GetMultipleOfEvenAndOdds(Math.Abs(num));

            Console.WriteLine(multiplication);

            static int GetMultipleOfEvenAndOdds(int num)
            {
                int evenSum = GetSumOfEvenDigits(num);
                int oddSum = GetSumOfOddDigits(num);
                return evenSum * oddSum;
            }

        static int GetSumOfEvenDigits(int num)
            {
                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit % 2 == 0) 
                    {
                        sum += digit;
                    }
                    num /= 10;

                }
                return sum;
            }

            static int GetSumOfOddDigits(int num)
            {
                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit % 2 != 0)
                    {
                        sum += digit;
                    }
                    num /= 10;

                }
                return sum;
            }
        }
    }
}
