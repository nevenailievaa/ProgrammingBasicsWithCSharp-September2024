//Prices
double nylonPrice = 1.50;
double paintPrice = 14.50;
double paintThinnerPrice = 5.00;

//Reading Input
int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int paintThinnerNeeded = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());

//Materials Bill Calculation
double nylonSum = nylonPrice * (nylonNeeded + 2);
double paintSum = paintPrice * (paintNeeded + paintNeeded * 0.1);
double paintThinnerSum = paintThinnerPrice * paintThinnerNeeded;
double bagsPrice = 0.40;

double materialsPrice = paintSum + nylonSum + paintThinnerSum + bagsPrice;

//Workmen Bill Calculation
double workMenPrice = workingHours * (materialsPrice * 0.3);

//Output
Console.WriteLine(workMenPrice + materialsPrice);