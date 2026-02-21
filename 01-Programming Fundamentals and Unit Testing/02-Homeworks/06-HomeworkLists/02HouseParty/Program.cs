namespace _02HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int numOfGuestsOnList = int.Parse(Console.ReadLine());
         List<string> guests = new List<string>();

            for (int i = 0; i < numOfGuestsOnList; i++)
            {
                string command = Console.ReadLine();
                string[] commandAction = command.Split(" ");

                string name = commandAction[0];

                if (command.Contains ("is going!"))
                {  if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (command.Contains("is not going!"))
                {  if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    
                }
            }
            
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }

        }
    }
}