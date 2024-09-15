//Input
double recordInSeconds = double.Parse(Console.ReadLine());
double metersToSwim = double.Parse(Console.ReadLine());
double secondsForOneMeterSwim = double.Parse(Console.ReadLine());

//Calculations
double swimSecondsWithoutDelay = metersToSwim * secondsForOneMeterSwim;
int delayTimes = (int)metersToSwim / 15;

double swimSeconds = swimSecondsWithoutDelay + delayTimes * 12.5;

//Output
if (swimSeconds < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimSeconds:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {swimSeconds - recordInSeconds:f2} seconds slower.");
}
