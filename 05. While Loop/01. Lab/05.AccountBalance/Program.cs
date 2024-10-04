//Input
string input = Console.ReadLine();

//Calculations
double sum = 0;

while (input != "NoMoreMoney")
{
    double payment = double.Parse(input);

    if (payment < 0)
    {
        break;
    }

    sum += payment;
    Console.WriteLine($"Increase: {payment}");

    input = Console.ReadLine();
}

//Output
Console.WriteLine($"Total: {sum}");