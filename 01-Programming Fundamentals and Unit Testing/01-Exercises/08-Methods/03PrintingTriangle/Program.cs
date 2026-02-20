namespace _03PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintingTriangle(num);

            static void PrintingTriangle(int num)
            {
                for (int i = 1; i < num; i++)
                {
                    LinePrinting(1, i);
                }
                for (int j = num; j >= 1; j--)
                {
                    LinePrinting(1, j);
                }
        
            static void LinePrinting(int start, int end)
                {
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}