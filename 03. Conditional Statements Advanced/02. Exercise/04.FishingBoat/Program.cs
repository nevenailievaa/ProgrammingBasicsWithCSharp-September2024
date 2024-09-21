//Input
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishersCount = int.Parse(Console.ReadLine());

//Calculations
int rent = 0;

if (season == "Spring")
{
    rent = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    rent = 4200;
}
else if (season == "Winter")
{
    rent = 2600;
}

//Discounts
double bill = 0;

if (fishersCount <= 6)
{
    bill = rent * 0.9; //10% discount
} 
else if (fishersCount >= 7 && fishersCount <= 11)
{
    bill = rent * 0.85; //15% discount
}
else if (fishersCount >= 12)
{
    bill = rent * 0.75; //25% discount
}

//Additional Discount
if (fishersCount % 2 == 0 && season != "Autumn")
{
    bill = bill * 0.95; //5% discount
}

//Output
if (bill <= budget)
{
    double remainingMoney = budget - bill;
    Console.WriteLine($"Yes! You have {remainingMoney:f2} leva left.");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
}