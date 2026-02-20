
using System.Diagnostics.CodeAnalysis;

int currentNum = int.Parse(Console.ReadLine());
int num = 1;
int sum = 0;

while (currentNum > 0)
{
    num = currentNum % 10;
    sum += num;
    currentNum = currentNum / 10;
}
Console.WriteLine(sum);