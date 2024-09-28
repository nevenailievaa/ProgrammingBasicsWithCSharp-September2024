//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;

    if (number > maxNumber)
    {
        maxNumber = number;
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