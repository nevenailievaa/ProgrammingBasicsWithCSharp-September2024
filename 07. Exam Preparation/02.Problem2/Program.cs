// Input
double budget = double.Parse(Console.ReadLine());
int countOfNights = int.Parse(Console.ReadLine());
double priceForOneNight = double.Parse(Console.ReadLine());
int percentAdditionalExpenses = int.Parse(Console.ReadLine());

// Calculations
if (countOfNights > 7)
{
    priceForOneNight *= 0.95;
}

double priceForAllNights = countOfNights * priceForOneNight;
double additionalExpenses = percentAdditionalExpenses * budget / 100;

double finalPrice = priceForAllNights + additionalExpenses;

// Output
if (budget >= finalPrice)
{
    double moneyLeft = budget - finalPrice;
    Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
}
else
{
    double moneyNeeded = finalPrice - budget;
    Console.WriteLine($"{moneyNeeded:F2} leva needed.");
}
