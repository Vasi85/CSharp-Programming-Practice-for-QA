
using System.Xml.Schema;

string movieType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());
double premierTicket = 12.00;
double normalTicket = 7.50;
double discountTicket = 5.00;

int countOfTickets = row * seats;

switch (movieType)
{
    case "Premiere":
        double totalPremierPrice = countOfTickets * premierTicket;
        Console.WriteLine($"{totalPremierPrice:F2}");
        break;

    case "Normal":
        double totalNormalPrice = countOfTickets * normalTicket;
        Console.WriteLine($"{totalNormalPrice:F2}");
        break;

    case "Discount":
        double totalDiscountPrice = countOfTickets * discountTicket;
        Console.WriteLine($"{totalDiscountPrice:F2}");
        break;

    default:
        break;
}
