
double sneakersPrice = 0.6;
double uniformPrice = 0.8;
double ballPrice = 0.25;
double accessoriesPrice = 0.2;

int bascketballTrainingFee = int.Parse(Console.ReadLine());

double sneacersCost = bascketballTrainingFee * sneakersPrice;
double uniformCost = sneacersCost * uniformPrice;
double ballCost = uniformCost * ballPrice;
double accessoriesCost = ballCost * accessoriesPrice;

double totalCost = bascketballTrainingFee + sneacersCost + uniformCost + ballCost + accessoriesCost;

Console.WriteLine(totalCost);