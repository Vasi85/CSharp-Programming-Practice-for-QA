
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int num = 1; num <= n; num++)
{
    
    Console.Write(num);
     sum += num;

    if (num != n)
    {
        Console.Write("+");
    }
    else { 
    Console.Write($"={sum}");
    }
}