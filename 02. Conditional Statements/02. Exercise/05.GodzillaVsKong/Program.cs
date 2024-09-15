//Input
double movieBudget = double.Parse(Console.ReadLine());
double backgroundActorsCount = double.Parse(Console.ReadLine());
double backgroundActorClothingPrice = double.Parse(Console.ReadLine());

//Calculations
double decorPrice = movieBudget * 0.1;
double backgroundActorsClothingSum = backgroundActorsCount * backgroundActorClothingPrice;

if (backgroundActorsCount > 150)
{
    backgroundActorsClothingSum *= 0.9;
}

double sum = decorPrice + backgroundActorsClothingSum;

//Output
if (sum > movieBudget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {sum - movieBudget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {movieBudget - sum:f2} leva left.");
}