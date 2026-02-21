namespace _06ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            int rotationNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationNum % nums.Length; i++)
            {
                int firstNum = nums[0];
                
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}