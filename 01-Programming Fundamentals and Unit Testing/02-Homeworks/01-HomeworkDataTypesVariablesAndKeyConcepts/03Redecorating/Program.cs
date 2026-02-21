
double nylonPricePerSquareMeter = 1.50;
double paintPricePerLiter = 14.50;
double paintThinnerPricePerLiter = 5.00;
double bags = 0.40;
double nylonExtra = +2;
double paintExtra = 1.1;

double nylon = double.Parse(Console.ReadLine());
double paint = double.Parse(Console.ReadLine());
double paintThinner = double.Parse(Console.ReadLine());
double workHours = double.Parse(Console.ReadLine());
double amountPaintForOneHourPercentege = 0.3;

double nylonCost = (nylon + nylonExtra) * nylonPricePerSquareMeter;
double paintCost = paint * paintPricePerLiter * paintExtra;
double paintThinnerCost = paintThinner * paintThinnerPricePerLiter;

double amountForMaterials = nylonCost + paintCost + paintThinnerCost + bags;

double amountPaintForOneHour = amountForMaterials * amountPaintForOneHourPercentege;
double amountPaintPrice = workHours * amountPaintForOneHour;

double amountPrice = amountForMaterials + amountPaintPrice;

Console.WriteLine(amountPrice);

