namespace _01WaterConsumption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            int cumulativeWater = 0;

            if (countOfDays <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < countOfDays; i++)
            {
                int water = int.Parse(Console.ReadLine());

                {
                    cumulativeWater += water;
                    Console.WriteLine(cumulativeWater);
                }

            }
            
        }
    }
}