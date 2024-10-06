
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakePieces = width * length;

while (true)
{
	string input = Console.ReadLine();

	if (input == "STOP")
		break;

	int currentPieces = int.Parse(input);
	cakePieces -= currentPieces;

	if (cakePieces < 0)
		break;
}

if (cakePieces >= 0)
{
    Console.WriteLine($"{cakePieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
}
