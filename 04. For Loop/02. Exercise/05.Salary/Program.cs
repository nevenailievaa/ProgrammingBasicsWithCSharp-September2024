//Input
int tabsOpened = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//Calculations
for (int i = 1; i <= tabsOpened; i++)
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

    //If the user has lost his salary
    if (salary <= 0)
    {
        //Output
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

//Output
if (salary > 0)
{
    Console.WriteLine(salary);
}