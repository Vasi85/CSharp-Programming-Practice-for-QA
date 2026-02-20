namespace _03ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
               {
                   nums[i] = int.Parse(Console.ReadLine());
               }
            for (int i = num - 1; i >= 0; i--)
               {
                   Console.Write(nums[i] + " ");
               }
          /*  int n = int.Parse(Console.ReadLine());

            // Create an array to store the numbers
            int[] numbers = new int[n];

            // Read N numbers and store them in the array
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Print the array in reverse order
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }*/
        }
    }
}