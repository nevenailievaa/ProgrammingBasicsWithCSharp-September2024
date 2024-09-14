//square, rectangle, circle или triangle

string figure = Console.ReadLine();
double area = 0;

if (figure == "square")
{
	double sideA = double.Parse(Console.ReadLine());
	area = sideA * sideA;
}
else if (figure == "rectangle")
{
	double sideA = double.Parse(Console.ReadLine());
	double sideB = double.Parse(Console.ReadLine());
	area = sideA * sideB;
}
else if (figure == "circle")
{
	double radius = double.Parse(Console.ReadLine());
	area = Math.PI * Math.Pow(radius, 2);
}
else if (figure == "triangle")
{
	double sideA = double.Parse(Console.ReadLine());
	double heightA = double.Parse(Console.ReadLine());
	area = sideA * heightA / 2;	
}

Console.WriteLine($"{area:F3}");