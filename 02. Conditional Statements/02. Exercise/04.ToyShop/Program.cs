//Prices
double puzzlePrice = 2.60;
double dollPrice = 3;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2;

//Input
double excursionPrice = double.Parse(Console.ReadLine());
int puzzlesCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

//Calculations
double toysBill = (puzzlePrice * puzzlesCount) + (dollPrice * dollsCount) + (bearPrice * bearsCount) + (minionPrice * minionsCount) + (truckPrice * trucksCount);

int toysCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;

if (toysCount >= 50)
{
    toysBill = toysBill * 0.75;
}

double shopRent = toysBill * 0.1;
toysBill -= shopRent;

//Output
if (toysBill >= excursionPrice)
{
    Console.WriteLine($"Yes! {toysBill - excursionPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {excursionPrice - toysBill:f2} lv needed.");
}