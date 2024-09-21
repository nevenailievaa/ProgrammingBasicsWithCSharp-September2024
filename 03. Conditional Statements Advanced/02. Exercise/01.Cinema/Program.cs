//Input
string projectionType = Console.ReadLine();
int rowsCount = int.Parse(Console.ReadLine());
int colsCount = int.Parse(Console.ReadLine());

//Calculations
double income = 0;

switch (projectionType)
{
	case "Premiere":
		income = rowsCount * colsCount * 12;
		break;
    case "Normal":
        income = rowsCount * colsCount * 7.50;
        break;
    case "Discount":
        income = rowsCount * colsCount * 5;
        break;
}

//Output
Console.WriteLine($"{income:f2} leva");