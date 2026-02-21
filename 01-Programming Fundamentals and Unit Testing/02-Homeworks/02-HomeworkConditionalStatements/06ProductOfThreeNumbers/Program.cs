
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());

double add = num1 * num2 * num3;

if (add > 0)
{
    Console.WriteLine("positive");
}
else if (add < 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("zero");
}
