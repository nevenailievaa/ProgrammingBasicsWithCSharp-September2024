//Input
double budget = double.Parse(Console.ReadLine());
int videocardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramsCount = int.Parse(Console.ReadLine());

//Prices Calculation
double videocardsBill = videocardsCount * 250;
double processorsBill = processorsCount * (videocardsBill * 0.35);
double ramsBill = ramsCount * (videocardsBill * 0.1);

double bill = videocardsBill + processorsBill + ramsBill;

//Discount
if (videocardsCount > processorsCount)
{
    //bill -= (bill * 0.15);
    bill = bill - (bill * 0.15);
}

//Output
if (bill <= budget)
{
    double moneyLeft = budget - bill;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
}
