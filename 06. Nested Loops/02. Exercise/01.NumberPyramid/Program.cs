//Input
int n = int.Parse(Console.ReadLine());

//Pyramid Print
int currentNumber = 1;
bool isBigger = false;

for (int rows = 1; rows <= n; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (currentNumber > n)
        {
            isBigger = true;
            break;
        }

        //Output
        Console.Write(currentNumber + " ");
        currentNumber++;
    }

    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
}