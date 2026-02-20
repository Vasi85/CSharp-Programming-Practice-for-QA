namespace _06MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int baseNum = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        Base(baseNum, power);
        static void Base(int baseNum, int power)
            {
                int result = 1;
                for (int i = 1; i <= power; i++)
                {
                    result *= baseNum;
                }
                Console.WriteLine(result);
            }
        }
    }
}