namespace _05Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int nums = int.Parse(Console.ReadLine());

            int[] firstArray = new int[nums];
            int[] secondArray = new int[nums];

        for (int i = 0; i < nums; i++)
            {
                int[] array = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToArray();
                int firstArrayNum = array[0];
                int secondArrayNum = array[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstArrayNum;
                    secondArray[i] = secondArrayNum;
                }
                else
                {
                    firstArray[i] = secondArrayNum;
                    secondArray[i] = firstArrayNum;
                }
            }
        Console.WriteLine(string.Join(" ", firstArray));
        Console.WriteLine(string.Join (" ", secondArray));
        }
    }
}