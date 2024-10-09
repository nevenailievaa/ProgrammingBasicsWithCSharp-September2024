//Input
string input = Console.ReadLine();

//Calculations
double sum = 0;

while (input != "NoMoreMoney")
{
    double payment = double.Parse(input);

    if (payment < 0)
    {
        Console.WriteLine($"Invalid operation!");
        break;
    }

    sum += payment;
    Console.WriteLine($"Increase: {payment:f2}");

    input = Console.ReadLine();
}

//Output
Console.WriteLine($"Total: {sum:f2}");
