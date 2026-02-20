
string enter = Console.ReadLine();

while (enter != "End")
{
    int num = int.Parse(enter);
    int sumOfDigits = 0;

    while (num > 0)
    {
        int digits = num % 10;
        sumOfDigits += digits;
        num /= 10;
    }
    Console.WriteLine($"Sum of digits = {sumOfDigits}");

    enter = Console.ReadLine();
}
Console.WriteLine("Goodbye");