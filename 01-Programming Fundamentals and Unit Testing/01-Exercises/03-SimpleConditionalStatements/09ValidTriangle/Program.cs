
int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

int sumAB = sideA + sideB;
int sumBC = sideB + sideC;
int sumAC = sideA + sideC;

if (sideA >= sumBC)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideB >= sumAC)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideC >= sumAB)
{
    Console.WriteLine("Invalid Triangle");
}
else
{
    Console.WriteLine("Valid Triangle");
}
