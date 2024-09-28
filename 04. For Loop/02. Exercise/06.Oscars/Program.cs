//Input
string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int juryCount = int.Parse(Console.ReadLine());

//Calculations
double points = academyPoints;

for (int i = 1; i <= juryCount; i++)
{
    string juryName = Console.ReadLine();
    double juryPoints = double.Parse(Console.ReadLine());

    points += juryName.Length * juryPoints / 2;

    //Success
    if (points > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        return; //Ending the whole program
    }
}

//Failure
double neededPoints = 1250.5 - points;
Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");