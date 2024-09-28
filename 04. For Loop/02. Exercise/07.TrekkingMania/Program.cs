//Input
int groupsCount = int.Parse(Console.ReadLine());

//Calculations
int peopleCount = 0;

int peopleMusala = 0;
int peopleMonblan = 0;
int peopleKilimandzharo = 0;
int peopleK2 = 0;
int peopleEverest = 0;

for (int i = 1; i <= groupsCount; i++)
{
    int currentPeopleCount = int.Parse(Console.ReadLine());
    peopleCount += currentPeopleCount;

    if (currentPeopleCount <= 5)
    {
        peopleMusala += currentPeopleCount;
    }
    else if (currentPeopleCount >= 6 && currentPeopleCount <= 12)
    {
        peopleMonblan += currentPeopleCount;
    }
    else if (currentPeopleCount >= 13 && currentPeopleCount <= 25)
    {
        peopleKilimandzharo += currentPeopleCount;
    }
    else if (currentPeopleCount >= 26 && currentPeopleCount <= 40)
    {
        peopleK2 += currentPeopleCount;
    }
    else if (currentPeopleCount >= 41)
    {
        peopleEverest += currentPeopleCount;
    }
}

double percentMusala = (double)peopleMusala / peopleCount * 100;
double percentMonblan = (double)peopleMonblan / peopleCount * 100;
double percentKilimandzharo = (double)peopleKilimandzharo / peopleCount * 100;
double percentK2 = (double)peopleK2 / peopleCount * 100;
double percentEverest = (double)peopleEverest / peopleCount * 100;

//Output
Console.WriteLine($"{percentMusala:f2}%");
Console.WriteLine($"{percentMonblan:f2}%");
Console.WriteLine($"{percentKilimandzharo:f2}%");
Console.WriteLine($"{percentK2:f2}%");
Console.WriteLine($"{percentEverest:f2}%");