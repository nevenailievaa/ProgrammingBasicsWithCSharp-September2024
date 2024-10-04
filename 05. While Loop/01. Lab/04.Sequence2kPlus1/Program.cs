//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int currentNumber = 1;

while (currentNumber <= n)
{
    Console.WriteLine(currentNumber);
    currentNumber = currentNumber * 2 + 1;
}