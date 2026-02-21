
using System.ComponentModel.Design;
using System.Xml.Schema;

string season = Console.ReadLine();
string place = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double springHotelPricePerDay = 30;
double springCampingPricePerDay = 10;
double summerHotelPricePerDay = 50;
double summerCampingPricePerDay = 30;
double autumnHotelPricePerDay = 20;
double autumnCampingPricePerDay = 15;
double winterHotelPricePerDay = 40;
double winterCampingPricePerDay = 10;
double discount = 1;

if (season == "Spring")
{
    discount = 0.8;
    {
        if (place == "Hotel")
        {
            double totalSpringHotelPrice = springHotelPricePerDay * days * discount;
            Console.WriteLine($"{totalSpringHotelPrice:F2}");
        }
        else if (place == "Camping")
        {
            double totalSpringCampingPrice = springCampingPricePerDay * days * discount;
            Console.WriteLine($"{totalSpringCampingPrice:F2}");
        }
    }

}
else if (season == "Summer")
    {
    if (place == "Hotel")
    {
        double totalSummerHotelPrice = summerHotelPricePerDay * days;
        Console.WriteLine($"{totalSummerHotelPrice:F2}");
    }
    else if (place == "Camping")
    {
        double totalSummerCampingPrice = summerCampingPricePerDay * days;
        Console.WriteLine($"{totalSummerCampingPrice:F2}");
    }
}
else if (season == "Autumn")
{
    discount = 0.7;
    {
        if (place == "Hotel")
        {
            double totalAutumnHotelPrice = autumnHotelPricePerDay * days * discount;
            Console.WriteLine($"{totalAutumnHotelPrice:F2}");
        }
        else if (place == "Camping")
        {
            double totalAutumnCampingPrice = autumnCampingPricePerDay * days * discount;
            Console.WriteLine($"{totalAutumnCampingPrice:F2}");
        }
    }
    
}
else if (season == "Winter")
{
    discount = 0.9;
    {
        if (place == "Hotel")
        {
            double totalWinterHotelPrice = winterHotelPricePerDay * days * discount;
            Console.WriteLine($"{totalWinterHotelPrice:F2}");
        }
        else if (place == "Camping")
        {
            double totalWinterCampingPrice = winterCampingPricePerDay * days * discount;
            Console.WriteLine($"{totalWinterCampingPrice:F2}");
        }
    }

}
