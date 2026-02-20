
int numberOfPages = int.Parse(Console.ReadLine());
int pagesForOneHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int totalHours = numberOfPages / pagesForOneHour;
int hoursPerDay = totalHours / numberOfDays;

Console.WriteLine(hoursPerDay);
