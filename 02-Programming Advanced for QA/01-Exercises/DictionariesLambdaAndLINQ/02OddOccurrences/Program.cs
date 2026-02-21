namespace _02OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').Select(i => i.ToLower()).ToList();
            Dictionary<string, int> wordCollection = new Dictionary<string, int>();

        for (int i = 0; i < input.Count; i++)
            {
                string keyString = input[i];

                if (wordCollection.ContainsKey(keyString))
                {
                    wordCollection[keyString]++;
                }
                else
                {
                    wordCollection.Add(keyString, 1);
                }
            }
        foreach (var item in wordCollection)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
            
        }
    }
}