//Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

//Calculations
string destination = "";
string place = "";
double spentMoney = 0;

if (budget <= 100)
{
    destination = "Bulgaria";

    if (season == "summer")
    {
        place = "Camp";
        spentMoney = budget * 0.3;
    }
    else if (season == "winter")
    {
        place = "Hotel";
        spentMoney = budget * 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    if (season == "summer")
    {
        place = "Camp";
        spentMoney = budget * 0.4;
    }
    else if (season == "winter")
    {
        place = "Hotel";
        spentMoney = budget * 0.8;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    place = "Hotel";
    spentMoney = budget * 0.9;
}

//Output
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{place} - {spentMoney:f2}");