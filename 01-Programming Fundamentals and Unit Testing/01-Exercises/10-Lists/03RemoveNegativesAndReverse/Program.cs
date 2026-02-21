namespace _03RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<int> numsList = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToList();
            for (int i = 0; i < numsList.Count; i++)
            {
                if (numsList[i] < 0)
                {
                    numsList.RemoveAt(i);
                    i--;
                }
            }
            numsList.Reverse();

            if (numsList.Count != 0)
            {
                Console.WriteLine(string.Join(" ", numsList));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}