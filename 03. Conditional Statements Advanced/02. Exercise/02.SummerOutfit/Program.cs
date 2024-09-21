//Input
int degrees = int.Parse(Console.ReadLine());
string time = Console.ReadLine();

//Calculations
string outfit = "";
string shoes = "";

if (10 <= degrees && degrees <= 18)
{
	switch (time)
	{
		case "Morning":
			outfit = "Sweatshirt";
			shoes = "Sneakers";
			break;
        case "Afternoon":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (18 < degrees && degrees <= 24)
{
    switch (time)
    {
        case "Morning":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
    }
}
else if (degrees >= 25)
{
    switch (time)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}

//Output
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");