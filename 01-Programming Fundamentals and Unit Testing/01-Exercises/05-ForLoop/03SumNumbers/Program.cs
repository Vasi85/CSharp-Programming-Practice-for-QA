
using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= n; i++)
{
    double num = double.Parse(Console.ReadLine());
    sum += num;
}
    Console.WriteLine(sum);
