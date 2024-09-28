
int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n; i++)
{
	int currNum = int.Parse(Console.ReadLine());

	leftSum += currNum;
}

for (int i = 0; i < n; i++)
{
	int currNum = int.Parse(Console.ReadLine());

	rightSum += currNum;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}

