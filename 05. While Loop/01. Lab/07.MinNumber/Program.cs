//Input
string input = Console.ReadLine();

//Calculations
int minNumber = int.MaxValue;

while (input != "Stop")
{
    int currentNumber = int.Parse(input);

    if (currentNumber < minNumber)
    {
        minNumber = currentNumber;
    }

    input = Console.ReadLine();
}

//Output
Console.WriteLine(minNumber);