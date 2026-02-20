
double bathroomW = double.Parse(Console.ReadLine());
double bathroomH = double.Parse(Console.ReadLine());
double tileW = double.Parse(Console.ReadLine());
double tileH = double.Parse(Console.ReadLine());
double tilePersentage = 1.1;

double bathroomArea = bathroomW * bathroomH;
double bathroomSurplus = bathroomArea * tilePersentage;
double tileArea = tileW * tileH;
double tileNeeds = bathroomSurplus / tileArea;

Console.WriteLine(Math.Round(tileNeeds));