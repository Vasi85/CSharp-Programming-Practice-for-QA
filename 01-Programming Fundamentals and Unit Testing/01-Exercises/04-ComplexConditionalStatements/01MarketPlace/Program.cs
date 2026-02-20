
string fruit = Console.ReadLine();
string day = Console.ReadLine();

double kiwiWeekPrice = 2.20;
double kiwiWeekendPrice = 3.00;
double appleWeekPrice = 1.30;
double appleWeekendPrice = 1.60;
double bananaWeekPrice = 2.50;
double bananaWeekendPrice = 2.70;

/*if (fruit == "Banana")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{bananaWeekPrice:F2}");
    }
    else 
    {
        Console.WriteLine($"{bananaWeekendPrice:F2}");
    }
}
else if (fruit == "Apple")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{appleWeekPrice:F2}");
    }
    else
    {
        Console.WriteLine($"{appleWeekendPrice:F2}");
    }
}
else if (fruit == "Kiwi")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{kiwiWeekPrice:F2}");
    }
    else
    {
        Console.WriteLine($"{kiwiWeekendPrice:F2}");
    }
}
*/

if (fruit == "Banana" && day == "Weekday")
{
    Console.WriteLine($"{bananaWeekPrice:F2}");
}
else if (fruit == "Banana" && day == "Weekend")
{
    Console.WriteLine($"{bananaWeekendPrice:F2}");
}
else if (fruit == "Kiwi" && day == "Weekday")
{
    Console.WriteLine($"{kiwiWeekPrice:F2}");
}
else if (fruit == "Kiwi" && day == "Weekend")
{
    Console.WriteLine($"{kiwiWeekendPrice:F2}");
}
else if (fruit == "Apple" && day == "Weekday")
{
    Console.WriteLine($"{appleWeekPrice:F2}");
}
else if (fruit == "Apple" && day == "Weekend")
{
    Console.WriteLine($"{appleWeekendPrice:F2}");
}
