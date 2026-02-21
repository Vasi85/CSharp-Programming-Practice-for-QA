
int num = int.Parse(Console.ReadLine());
int currentNum = num;
bool isSpecial = true;

while (currentNum > 0)
{
    int digit = currentNum % 10;
    if (num % digit != 0)
    {
        isSpecial = false;
        break;
    }
    currentNum /= 10;
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}