namespace _01EqualArrays
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
            for (int i = 0; i < arrNum1.Length; i++)
            {
                int currentElementArrNum1 = arrNum1[i];
                int currentElementArrNum2 = arrNum2[i];

                if (currentElementArrNum1 != currentElementArrNum2)
                {
                    Console.WriteLine("Arrays are not identical.");
                    return;
                }
            }
            Console.WriteLine("Arrays are identical.");
        }
    }
}