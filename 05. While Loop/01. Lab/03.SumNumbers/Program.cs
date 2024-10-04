//Input
int number = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;

while (sum < number)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;
}

//Output
Console.WriteLine(sum);