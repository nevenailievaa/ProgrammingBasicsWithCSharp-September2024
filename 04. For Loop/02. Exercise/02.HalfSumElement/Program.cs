//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currrentNumber = int.Parse(Console.ReadLine());
    sum += currrentNumber;

    if (maxNumber < currrentNumber)
    {
        maxNumber = currrentNumber;
    }
}

int sumWithoutMaxNumber = sum - maxNumber;

//Output
if (maxNumber == sumWithoutMaxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNumber}");
}
else
{
    int difference = Math.Abs(maxNumber - sumWithoutMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}