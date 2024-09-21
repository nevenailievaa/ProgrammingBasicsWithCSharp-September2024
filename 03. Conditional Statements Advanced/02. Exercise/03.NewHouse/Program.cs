//Input
string flowersType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//Calculations
double bill = 0;

if (flowersType == "Roses")
{
    bill = 5 * flowersCount;

    if (flowersCount > 80)
    {
        bill = bill * 0.9; //10% discount
    }
}
else if (flowersType == "Dahlias")
{
    bill = 3.80 * flowersCount;

    if (flowersCount > 90)
    {
        bill = bill * 0.85; //15% discount
    }
}
else if (flowersType == "Tulips")
{
    bill = 2.80 * flowersCount;

    if (flowersCount > 80)
    {
        bill = bill * 0.85; //15% discount
    }
}
else if (flowersType == "Narcissus")
{
    bill = 3 * flowersCount;

    if (flowersCount < 120)
    {
        bill = bill * 1.15; //15% price up
    }
}
else if (flowersType == "Gladiolus")
{
    bill = 2.50 * flowersCount;

    if (flowersCount < 80)
    {
        bill = bill * 1.2; //20% price up
    }
}

//Output
if (bill <= budget)
{
    double remainingMoney = budget - bill;
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {remainingMoney:f2} leva left.");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
}