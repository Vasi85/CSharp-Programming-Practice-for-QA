
string ticketType = Console.ReadLine();
double priceForStudent = 1.00;
double priceForRegular = 1.60;
if (ticketType == "student")
{
    Console.WriteLine($"${priceForStudent:F2}");
}
else if (ticketType == "regular")
{
    Console.WriteLine($"${priceForRegular:F2}");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}