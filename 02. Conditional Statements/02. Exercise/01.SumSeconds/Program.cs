//Input
int firstPlayerTime = int.Parse(Console.ReadLine());
int secondPlayerTime = int.Parse(Console.ReadLine());
int thirdPlayerTime = int.Parse(Console.ReadLine());

//Time Calculation
int timeInSeconds = firstPlayerTime + secondPlayerTime + thirdPlayerTime;
int hours = timeInSeconds / 60;  //124 minutes / 60 = 2 hours
int minutes = timeInSeconds % 60; //124 minutes % 60 = 4 minutes

//Output
if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}