namespace _02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum1 = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();
            int[] arrNum2 = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();

            foreach (int i in arrNum1)
            {
                foreach (int j in arrNum2)
                {
                    if (i == j)
                    {
                        Console.Write($"{i} ");
                    }
                }
                
            }
        }
    }
}
