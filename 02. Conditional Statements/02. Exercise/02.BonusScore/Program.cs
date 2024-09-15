//Input
int number = int.Parse(Console.ReadLine());

//Calculations
double bonusBoints = 0;

if (number <= 100)
{
    bonusBoints = 5;
}
else if (number > 100 && number <= 1000)
{
    bonusBoints = number * 0.2;
}
else if (number > 1000)
{
    bonusBoints = number * 0.1;
}

double additionalBonusPoints = 0;

if (number % 2 == 0)
{
    additionalBonusPoints++;
}
else if (number % 10 == 5)
{
    additionalBonusPoints += 2;
}

//Output
Console.WriteLine(bonusBoints + additionalBonusPoints);
Console.WriteLine(number + bonusBoints + additionalBonusPoints);