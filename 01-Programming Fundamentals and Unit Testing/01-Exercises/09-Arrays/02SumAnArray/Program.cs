namespace _02SumAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                sum += currentNum;
            }
            Console.WriteLine(sum);
          }
      }
  }

            /*{
            
                {
                    // Read input and split it into an array of strings
                    string[] input = Console.ReadLine().Split(' ');

                    // Convert and sum the numbers using a for loop
                    int sum = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        sum += int.Parse(input[i]); // Convert each string to an integer and add to sum
                    }

                    // Print the result
                    Console.WriteLine(sum);
                }
            }
        }
    }
}*/

