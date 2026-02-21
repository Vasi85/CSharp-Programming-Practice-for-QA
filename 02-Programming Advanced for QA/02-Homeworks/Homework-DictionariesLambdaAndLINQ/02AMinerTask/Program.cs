namespace _02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> resourcesCount = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesCount.ContainsKey(resource))
                {
                    resourcesCount.Add(resource, 0);
                }
                resourcesCount[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in resourcesCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}