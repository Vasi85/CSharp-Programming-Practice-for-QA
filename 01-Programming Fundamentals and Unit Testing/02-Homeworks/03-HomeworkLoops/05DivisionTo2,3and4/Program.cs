
int n = int.Parse(Console.ReadLine());
double devisibleBy2 = 0;
double devisibleBy3 = 0;
double devisibleBy4 = 0;

for (int i = 1; i <= n; i++)
{
    double num = double.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        devisibleBy2++;
    }
    if (num % 3 == 0)
    {
        devisibleBy3++;
    }
    if (num % 4 == 0)
    {
        devisibleBy4++;
    }
        
}
    double devisibleBy2Per = (devisibleBy2 / n) * 100;
    double devisibleBy3Per = (devisibleBy3 / n) * 100;
    double devisibleBy4Per = (devisibleBy4 / n) * 100;

    Console.WriteLine($"{devisibleBy2Per:F2}%");
    Console.WriteLine($"{devisibleBy3Per:F2}%");
    Console.WriteLine($"{devisibleBy4Per:F2}%");