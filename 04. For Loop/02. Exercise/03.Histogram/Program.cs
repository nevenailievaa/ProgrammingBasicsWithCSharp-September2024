//Input
int n = int.Parse(Console.ReadLine());

int p1NumbersCount = 0;
int p2NumbersCount = 0;
int p3NumbersCount = 0;
int p4NumbersCount = 0;
int p5NumbersCount = 0;
int allNumbersCount = 0;

//Reading the Numbers
for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    allNumbersCount++;

    if (currentNumber < 200)
    {
        p1NumbersCount++;
    }
    else if (currentNumber >= 200 && currentNumber <= 399)
    {
        p2NumbersCount++;
    }
    else if (currentNumber >= 400 && currentNumber <= 599)
    {
        p3NumbersCount++;
    }
    else if (currentNumber >= 600 && currentNumber <= 799)
    {
        p4NumbersCount++;
    }
    else
    {
        p5NumbersCount++;
    }
}

//Calculating Percents
double p1NumbersPercent = (double)p1NumbersCount / allNumbersCount * 100;
double p2NumbersPercent = (double)p2NumbersCount / allNumbersCount * 100;
double p3NumbersPercent = (double)p3NumbersCount / allNumbersCount * 100;
double p4NumbersPercent = (double)p4NumbersCount / allNumbersCount * 100;
double p5NumbersPercent = (double)p5NumbersCount / allNumbersCount * 100;

//Output
Console.WriteLine($"{p1NumbersPercent:f2}%");
Console.WriteLine($"{p2NumbersPercent:f2}%");
Console.WriteLine($"{p3NumbersPercent:f2}%");
Console.WriteLine($"{p4NumbersPercent:f2}%");
Console.WriteLine($"{p5NumbersPercent:f2}%");