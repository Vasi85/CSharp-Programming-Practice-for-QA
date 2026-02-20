
double depositAmount = double.Parse(Console.ReadLine());
int mounts = int.Parse(Console.ReadLine());
double annualInterest = double.Parse(Console.ReadLine());

double annualInterestPerYear = depositAmount * annualInterest / 100;
double annualInterestPerMount = annualInterestPerYear / 12;
double annualInterestForThePeriod = mounts * annualInterestPerMount;
double totalAmount = depositAmount + annualInterestForThePeriod;

Console.WriteLine($"{totalAmount:F2}");