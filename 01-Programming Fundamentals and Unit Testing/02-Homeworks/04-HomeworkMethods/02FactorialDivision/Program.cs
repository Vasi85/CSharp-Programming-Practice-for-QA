namespace _02FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int factorial1 = FactorialCount(num1);
            int factorial2 = FactorialCount(num2);

            int divisionFactorial = factorial1 / factorial2;
            Console.WriteLine(divisionFactorial);

            static int FactorialCount(int num)
            {
                int result = 1;
                for (int i = 2; i <= num; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}