
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;
double deliveryPrice = 2.50;
double desertPricePercentage = 0.2;

int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double chickenMenuCost = chickenMenu * chickenMenuPrice;
double fishMenuCost = fishMenu * fishMenuPrice;
double vegetarianMenuCost = vegetarianMenu * vegetarianMenuPrice;
double totalCostOfMenus = chickenMenuCost + fishMenuCost + vegetarianMenuCost;
double desertCost = totalCostOfMenus * desertPricePercentage;

double totalOrderCost = totalCostOfMenus + desertCost + deliveryPrice;

Console.WriteLine(totalOrderCost);