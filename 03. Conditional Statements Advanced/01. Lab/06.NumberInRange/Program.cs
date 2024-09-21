
int number = int.Parse(Console.ReadLine());

bool isInRange = number >= -100 && number <= 100 && number != 0;

if (isInRange)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}