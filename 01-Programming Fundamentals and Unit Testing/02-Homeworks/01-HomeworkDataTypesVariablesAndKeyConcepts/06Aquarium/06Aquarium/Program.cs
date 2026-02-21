
int aquariumL = int.Parse(Console.ReadLine());
int aquariumW = int.Parse(Console.ReadLine());
int aquariumH = int.Parse(Console.ReadLine());
double occupiedSpacePercentage = double.Parse(Console.ReadLine());
double oneCubicCmWater = 0.001;

int aquariumVol = aquariumL * aquariumW * aquariumH;
double occupiedSpace = aquariumVol * occupiedSpacePercentage / 100;
double water = (aquariumVol - occupiedSpace) * oneCubicCmWater;

Console.WriteLine($"{water:F2}");

