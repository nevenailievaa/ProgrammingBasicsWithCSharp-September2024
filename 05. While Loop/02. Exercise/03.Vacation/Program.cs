
double moneyForTrip = double.Parse(Console.ReadLine());
double savedMoney = double.Parse(Console.ReadLine());

int allDaysCounter = 0;
int spendDaysCounter = 0;

while (savedMoney < moneyForTrip)
{
	string whatJessyDo = Console.ReadLine(); // "spend" or "save"
	double currentMoney = double.Parse(Console.ReadLine());

	allDaysCounter++;

	if (whatJessyDo == "spend")
	{
		spendDaysCounter++;
		savedMoney -= currentMoney;

		if (savedMoney < 0)
			savedMoney = 0;

		if (spendDaysCounter == 5)
		{
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{allDaysCounter}");
            break;
		}
	}
	else if (whatJessyDo == "save") 
	{
		spendDaysCounter = 0;
		savedMoney += currentMoney;
	}
}

if (savedMoney >= moneyForTrip )
{
	Console.WriteLine($"You saved the money for {allDaysCounter} days.");  
}
