
int num = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= 10; i++)
{
    result = num * i;
    Console.WriteLine($"{num} x {i} = {result}");
}