
using System.Security.Principal;

double balance = 0;

while (true)
{

    string action = Console.ReadLine();
    if (action == "End")
    {
        break;
    }

    double amount = double.Parse(action);
    balance += amount;
    if (amount > 0)
    {
        Console.WriteLine($"Increase: {amount:F2}");
    }
    else 
    {
        Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
    }

}
Console.WriteLine($"Balance: {balance:F2}");