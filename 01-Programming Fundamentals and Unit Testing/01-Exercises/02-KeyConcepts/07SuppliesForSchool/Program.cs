
double onePackageOfPenPrice = 5.80;
double onePackageOfMarkersPrice = 7.20;
double oneLiterBoardCleanerPrice = 1.20;

int packageOfPens = int.Parse(Console.ReadLine());
int packageOfMarkers = int.Parse(Console.ReadLine());
int boardCleaner = int.Parse(Console.ReadLine());
int discountPersentage = int.Parse(Console.ReadLine());

double packageOfPenCost = packageOfPens * onePackageOfPenPrice;
double packageOfMarkersCost = packageOfMarkers * onePackageOfMarkersPrice;
double boardCleanerCost = boardCleaner * oneLiterBoardCleanerPrice;

double materialsPrice = packageOfPenCost + packageOfMarkersCost + boardCleanerCost;

double materialsDiscount = materialsPrice * discountPersentage / 100;
double totalMaterialsCost = materialsPrice - materialsDiscount;

Console.WriteLine(totalMaterialsCost);
