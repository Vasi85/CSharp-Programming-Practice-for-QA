namespace _01DailyExerciseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            if (days <= 0)
            {
                Console.WriteLine(0);
            }

            int cumulativeExerciseTime = 0;
            for (int i = 1; i <= days; i++)
            {
                int minExercisePerDay = int.Parse(Console.ReadLine());
                cumulativeExerciseTime += minExercisePerDay;
                minExercisePerDay = cumulativeExerciseTime;
                Console.WriteLine(cumulativeExerciseTime);
                
            }
        }
    }
}