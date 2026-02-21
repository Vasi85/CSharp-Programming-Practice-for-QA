
int temperature = int.Parse(Console.ReadLine());
string partOfDay = Console.ReadLine();

string clothing = "Shirt";
string shoes = "Moccasins";

if ((temperature >= 10 && temperature <= 18 && partOfDay != "Morning") 
    || (temperature >= 25 && partOfDay == "Evening")
    || (temperature > 18 && temperature <=24 && partOfDay != "Afternoon"))
{
        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
}
else if (temperature >= 10 && temperature <= 18 && partOfDay == "Morning")
{
    clothing = "Sweatshirt";
    shoes = "Sneakers";
    Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
}
else if ((temperature > 18 && temperature <= 24 && partOfDay == "Afternoon") 
        || (temperature >= 25 && partOfDay == "Morning"))
{
    clothing = "T-Shirt";
    shoes = "Sandals";
    Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
}
else if (temperature >= 25 && partOfDay == "Afternoon")
{
    clothing = "Swim Suit";
    shoes = "Barefoot";
    Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
}
