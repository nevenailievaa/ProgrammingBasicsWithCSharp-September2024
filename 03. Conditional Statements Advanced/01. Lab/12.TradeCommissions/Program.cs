
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commision = 0;

if (city == "Sofia")
{
    if (sales < 0)
        Console.WriteLine("error");
    else if (sales >= 0 && sales <= 500)
        commision = 5;
    else if (sales > 500 && sales <= 1000)
        commision = 7;
    else if (sales > 1000 && sales <= 10000)
        commision = 8;
    else if (sales > 10000)
        commision = 12;
}
else if (city == "Varna")
{
	if (sales < 0)
		Console.WriteLine("error");
	else if (sales >= 0 && sales <= 500)
		commision = 4.5;
	else if (sales > 500 && sales <= 1000)
		commision = 7.5;
	else if (sales > 1000 && sales <= 10000)
		commision = 10;
	else if (sales > 10000)
		commision = 13;
}
else if (city == "Plovdiv")
{
    switch (sales)
    {
        case >= 0 and <= 500:
            commision = 5.5;
            break;
        case > 500 and <= 1000:
            commision = 8;
            break;
		case > 1000 and <= 10000:
			commision = 12;
			break;
        case > 10000:
            commision = 14.5;
            break;
        default:
            Console.WriteLine("error");
            break;
    }
}
else
{
    Console.WriteLine("error");
}

if (commision > 0)
{
	double output = commision * sales / 100;

	Console.WriteLine($"{output:F2}");
}

