//Menu Prices
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;

//Input
int ckickenMenusCount = int.Parse(Console.ReadLine());
int fishMenusCount = int.Parse(Console.ReadLine());
int vegetarianMenusCount = int.Parse(Console.ReadLine());

//Calculation
double bill = chickenMenuPrice * ckickenMenusCount + fishMenuPrice * fishMenusCount + vegetarianMenuPrice * vegetarianMenusCount;
double dessertPrice = bill * 0.2;

double finalBill = bill + dessertPrice + 2.50;

//Output
Console.WriteLine(finalBill);