
int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        count++;
        if (count > n)
            { 
            break; 
            }

        Console.Write($"{count} ");
    }
    Console.WriteLine();
}