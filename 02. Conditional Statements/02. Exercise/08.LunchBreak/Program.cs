//Input
string seriesName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());


//Calculations
double lunchTime = breakLength / 8.0;
double freeTime = breakLength / 4.0;
double allNeededTime = lunchTime + freeTime + episodeLength;

//Output
if (breakLength >= allNeededTime)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(breakLength - allNeededTime)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(allNeededTime - breakLength)} more minutes.");
}