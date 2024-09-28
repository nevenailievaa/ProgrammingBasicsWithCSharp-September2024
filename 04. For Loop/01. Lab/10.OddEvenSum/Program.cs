
int n = int.Parse(Console.ReadLine());
int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < n; i++)
{
	if (i % 2 == 0)
	{
		int currentNum = int.Parse(Console.ReadLine());
		evenSum += currentNum;
	}
	else
	{
		int currentNum = int.Parse(Console.ReadLine());
		oddSum += currentNum;
	}
}

if (oddSum == evenSum)
{
	Console.WriteLine("Yes");
	Console.WriteLine($"Sum = {evenSum}");
}
else
{
	int diff = Math.Abs(evenSum - oddSum);
	Console.WriteLine("No");
	Console.WriteLine($"Diff = {diff}");
}
