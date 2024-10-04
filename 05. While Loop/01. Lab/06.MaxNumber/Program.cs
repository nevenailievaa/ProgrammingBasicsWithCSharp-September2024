//Input
string input = Console.ReadLine();

//Calculations
int maxNumber = int.MinValue;

while (input != "Stop")
{
    int currentNumber = int.Parse(input);

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }

    input = Console.ReadLine();
}

//Output
Console.WriteLine(maxNumber);