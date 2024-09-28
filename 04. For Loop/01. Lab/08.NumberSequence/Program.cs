// Input
using System.Reflection;

int n = int.Parse(Console.ReadLine());

// Action or Calculations

int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = 1; i <= n; i++)
{
	// всеки път чета ново число от конзолата	
	int currentNum = int.Parse(Console.ReadLine());

	// проверявам дали имам ново най-голямо число
	if (currentNum > maxNumber)
	{
		maxNumber = currentNum;
	}
	// проверявам дали имам ново най-малко число
	if (currentNum < minNumber)
	{
		minNumber = currentNum; 
	}
}

// Output
Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");