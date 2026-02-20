
using System.Data;

int num = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command !="End")
{
    if (command == "Inc")
    { 
        ++num;
        command = Console.ReadLine();
    }
    else if (command == "Dec")
    {
        --num;
        command = Console.ReadLine();
    }
}
Console.WriteLine(num);