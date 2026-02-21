namespace _03MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        string product = MultiplicationSing(num1, num2, num3);

        Console.WriteLine(product);

         static string MultiplicationSing(int a, int b, int c)
            {
                string result = "";

                if (a == 0 || b == 0 || c == 0)
                {
                    return "zero";
                }
              
                int negative = 0;
                if (a <  0)
                {
                    negative ++;
                }
                if (b < 0)
                {
                    negative ++;   
                }
                if (c < 0)
                {
                    negative ++;
                }
                
                if (negative % 2 == 0)
                {
                    return "positive";
                }
                else
                {
                    return "negative";
                }
            }   
        }
    }
}