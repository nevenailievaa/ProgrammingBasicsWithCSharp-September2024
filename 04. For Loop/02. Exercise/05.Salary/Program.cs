//Input
int tabsCount = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//Calculations
for (int i = 1; i <= tabsCount; i++)
{
    string currentSite = Console.ReadLine();

    if (currentSite == "Facebook")
    {
        salary -= 150;
    }
    else if (currentSite == "Instagram")
    {
        salary -= 100;
    }
    else if (currentSite == "Reddit")
    {
        salary -= 50;
    }

    //Output
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        return;
    }
}

//Output
Console.WriteLine(salary);