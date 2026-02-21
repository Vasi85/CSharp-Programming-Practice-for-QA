namespace _04SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');

                string cmd = commands[0];
                string userName = commands[1];

                if (cmd == "register")
                {
                    string licensePlateNumber = commands[2];

                    if (parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    if (!parking.ContainsKey(userName))
                    {
                        parking.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if (cmd == "unregister")
                {
                    if (!parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parking.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}