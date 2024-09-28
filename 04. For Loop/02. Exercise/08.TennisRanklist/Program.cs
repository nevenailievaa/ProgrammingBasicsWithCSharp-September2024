//Input
int tournamentsCount = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

//Calculations
int points = 0;
int winsCount = 0;

for (int i = 1; i <= tournamentsCount; i++)
{
    string tournamentStage = Console.ReadLine();

    if (tournamentStage == "W")
    {
        points += 2000;
        winsCount++;
    }
    else if (tournamentStage == "F")
    {
        points += 1200;
    }
    if (tournamentStage == "SF")
    {
        points += 720;
    }
}

double averagePoints = (double)points / tournamentsCount;
double percentWins = (double)winsCount / tournamentsCount * 100;

points += initialPoints;

//Output
Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentWins:f2}%");