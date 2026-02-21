namespace _01MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> magicNumber = new List<int>();

            for (int i = 1; i < N; i++)
            {
                int currentNumber = i;
                bool IsPrime = true;
                int sum = 0;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += currentDigit;

                    IsPrime = IsPrimeNum(currentDigit);
                    if (!IsPrime)
                    {
                        break;
                    }

                }
                if (IsPrime && sum % 2 == 0)
                {
                    magicNumber.Add(i);
                }
            }
            if (magicNumber.Count > 0)
            { 
                Console.WriteLine(string.Join(", ", magicNumber));
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        public static bool IsPrimeNum(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (2 % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}