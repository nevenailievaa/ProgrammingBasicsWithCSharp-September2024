
string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double priceOfProduct = 0;

if (city == "Sofia")
{
    switch (product)
	{
		case "coffee": priceOfProduct = 0.50; break;
		case "water": priceOfProduct = 0.80; break;
		case "beer": priceOfProduct = 1.20;	break;
		case "sweets": priceOfProduct = 1.45; break;
		case "peanuts": priceOfProduct = 1.60; break;
	}
}
else if (city == "Plovdiv")
{
	switch (product)
	{
		case "coffee": priceOfProduct = 0.40; break;
		case "water": priceOfProduct = 0.70; break;
		case "beer": priceOfProduct = 1.15; break;
		case "sweets": priceOfProduct = 1.30; break;
		case "peanuts": priceOfProduct = 1.50; break;
	}
}
else if (city == "Varna")
{
	switch (product)
	{
		case "coffee": priceOfProduct = 0.45; break;
		case "water": priceOfProduct = 0.70; break;
		case "beer": priceOfProduct = 1.10; break;
		case "sweets": priceOfProduct = 1.35; break;
		case "peanuts": priceOfProduct = 1.55; break;
	}
}

double finalPrice = priceOfProduct * quantity;

Console.WriteLine(finalPrice);

