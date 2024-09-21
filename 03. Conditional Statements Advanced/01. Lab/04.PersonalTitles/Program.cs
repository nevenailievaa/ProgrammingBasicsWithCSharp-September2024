
double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'm')
{
	if (age >= 16)
	{
        Console.WriteLine("Mr.");
    }
	else
	{
        Console.WriteLine("Master");
    }
}
else if (gender == 'f')
{
	if (age >= 16)
	{
		Console.WriteLine("Ms.");
	}
	else
	{
		Console.WriteLine("Miss");
	}
}