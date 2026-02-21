namespace _01ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<int> nums = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToList();
             string command = Console.ReadLine();
            while (command != "end")
              {
                 string[] commandNum = command.Split(" ");
                 string commandAction = commandNum[0];

                 if (commandAction == "Delete")
                 {
                    int numberToRemove = int.Parse(commandNum[1]);

                     for (int i = 0; i < nums.Count; i++)
                     {
                        if (nums[i] == numberToRemove)
                        {
                             nums.RemoveAt(i);
                             i--;
                        }
                        }
                     }
                else if (commandAction == "Insert")
                {
                    int element = int.Parse(commandNum[1]);
                    int position = int.Parse(commandNum[2]);

                    nums.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}