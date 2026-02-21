namespace _03WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string symonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(symonym);
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}