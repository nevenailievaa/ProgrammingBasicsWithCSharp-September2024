int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int freeSpace = width * length * height;

while (freeSpace > 0)
{
	string input = Console.ReadLine();

	if (input == "Done")
		break;

	freeSpace -= int.Parse(input);
}

if (freeSpace >= 0)
{
	Console.WriteLine($"{freeSpace} Cubic meters left.");
}
else
{
	Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
}