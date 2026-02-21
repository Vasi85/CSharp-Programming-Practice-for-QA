
int n = int.Parse(Console.ReadLine());
int biggestNum = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > biggestNum)
    {
        biggestNum = num;
    }
}
Console.WriteLine(biggestNum);