//Input
double budget = double.Parse(Console.ReadLine());
double videocardsCount = double.Parse(Console.ReadLine());
double processorsCount = double.Parse(Console.ReadLine());
double ramsCount = double.Parse(Console.ReadLine());


//Prices Calculations
double videocardsSum = 250 * videocardsCount;
double processorsSum = processorsCount * (videocardsSum * 0.35);
double ramsSum = ramsCount * (videocardsSum * 0.1);

double sum = videocardsSum + processorsSum + ramsSum;

if (videocardsCount > processorsCount)
{
    sum -= sum * 0.15;
}

//Output
if (sum <= budget)
{
    Console.WriteLine($"You have {budget - sum:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
}