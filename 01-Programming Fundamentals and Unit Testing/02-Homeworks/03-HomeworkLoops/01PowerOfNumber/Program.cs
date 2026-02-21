
using System;

int num = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
int result = num;

for (int i = 1; i < power; i++)
{
     result *= num;
}
Console.WriteLine(result);
