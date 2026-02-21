namespace _01CalculateFactorialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(FactorialCalculate(number));
            }
        }

        public static int FactorialCalculate(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * FactorialCalculate(number - 1);
        }
    }
}