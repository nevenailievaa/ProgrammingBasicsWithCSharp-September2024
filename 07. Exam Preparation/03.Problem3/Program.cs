// Input

double budget = double.Parse(Console.ReadLine());
//"Dubai", "Sofia" и "London"
string destination = Console.ReadLine();
//"Summer" и "Winter"
string season = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

// Calculations
double priceForOneDay = 0;

switch (season)
{
    case "Winter":
        switch (destination)
        {
            case "Dubai":
                // слагаме 30% отстъпка заради дестинацията
                priceForOneDay = 45000 * 0.7;
                break;
            case "Sofia":
                // слагаме 25% оскъпяване заради дестинацията
                priceForOneDay = 17000 * 1.25;
                break;
            case "London":
                priceForOneDay = 24000;
                break;
        }
        break;
    case "Summer":
        switch (destination)
        {
            case "Dubai":
                // слагаме 30% отстъпка заради дестинацията
                priceForOneDay = 40000 * 0.7;
                break;
            case "Sofia":
                // слагаме 25% оскъпяване заради дестинацията
                priceForOneDay = 12500 * 1.25;
                break;
            case "London":
                priceForOneDay = 20250;
                break;
        }
        break;
}

double finalPrice = countOfDays * priceForOneDay;

// Output
double difference = Math.Abs(budget - finalPrice);

if (budget >= finalPrice)
{
    Console.WriteLine($"The budget for the movie is enough! We have {difference:F2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {difference:F2} leva more!");
}
