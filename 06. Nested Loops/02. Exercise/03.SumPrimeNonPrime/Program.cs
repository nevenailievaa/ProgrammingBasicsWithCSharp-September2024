// - Ако числото е по-малко или равно на 1, то не е просто.
// - Ако числото е 2, то е просто (тъй като 2 е най-малкото и единствено четно просто число).
// - Ако числото е четно и по-голямо от 2, то не е просто.
// - За нечетни числа, по-големи от 2, проверяваме модулна делимост, започвайки от 3
// до квадратния корен от числото, като увеличаваме с 2 (за да пропуснем четните числа). Тези числа не са прости.

//Input
string input = "";

//Calculations
int primeNumsSum = 0;
int nonPrimeNumsSum = 0;

while ((input = Console.ReadLine()) != "stop")
{
    int number = int.Parse(input);

    //Check if the Number is Negative
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    //Prime or Non Prime Check
    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else if (number != 2 && number % 2 == 0)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 3; i <= Math.Sqrt(number); i+=2)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        primeNumsSum += number;
    }
    else
    {
        nonPrimeNumsSum += number;
    }
}

//Output
Console.WriteLine($"Sum of all prime numbers is: {primeNumsSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumsSum}");
