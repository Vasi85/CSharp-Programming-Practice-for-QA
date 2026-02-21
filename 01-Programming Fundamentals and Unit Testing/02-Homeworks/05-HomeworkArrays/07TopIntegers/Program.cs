namespace _07TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = Console.ReadLine()
                                    .Split(" ")
                                    .Select(int.Parse)
                                    .ToArray();
            for (int i = 0; i < arrayNum.Length; i++)
            {
                int number = arrayNum[i];
                bool IsTopNumber = true;

                for (int j = i + 1; j < arrayNum.Length; j++)
                {
                    if (number <= arrayNum[j])
                    {
                        IsTopNumber = false;
                        break;
                    }
                }
                if (IsTopNumber)
                {
                    Console.Write($"{number} ");
                } 
            }
        }
    }
}