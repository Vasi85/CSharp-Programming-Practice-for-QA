
int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

int totalTime = time1 + time2 + time3;

int totalTimeInMinutes = totalTime / 60;
int totalTimeInSeconds = totalTime % 60;

Console.WriteLine($"{totalTimeInMinutes}:{totalTimeInSeconds:D2}");
