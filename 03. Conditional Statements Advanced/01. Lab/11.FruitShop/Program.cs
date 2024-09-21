
string fruit = Console.ReadLine();
string weekDay = Console.ReadLine();
double count = double.Parse(Console.ReadLine());

double price = 0;

if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
{
	switch (fruit)
	{
		case "banana":
			price = count * 2.50;
			break;
		case "apple":
			price = count * 1.20;
			break;
		case "orange":
			price = count * 0.85;
			break;
		case "grapefruit":
			price = count * 1.45;
			break;
		case "kiwi":
			price = count * 2.70;
			break;
		case "pineapple":
			price = count * 5.50;
			break;
		case "grapes":
			price = count * 3.85;
			break;
		default:
			Console.WriteLine("error");
			break;
	}
}
else if (weekDay == "Saturday" || weekDay == "Sunday")
{
	switch (fruit)
	{
		case "banana":
			price = count * 2.70;
			break;
		case "apple":
			price = count * 1.25;
			break;
		case "orange":
			price = count * 0.90;
			break;
		case "grapefruit":
			price = count * 1.60;
			break;
		case "kiwi":
			price = count * 3.00;
			break;
		case "pineapple":
			price = count * 5.60;
			break;
		case "grapes":
			price = count * 4.20;
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

if (price > 0)
{
	Console.WriteLine($"{price:f2}");
}
