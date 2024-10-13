//Input
int n = int.Parse(Console.ReadLine());

//Pyramid Print
int currentNumber = 0;
bool isBigger = false;

//Rows
for (int row = 1; row <= n; row++)
{
    //Cols
    for (int col = 1; col <= row; col++)
    {
        currentNumber++;

        if (currentNumber > n)
        {
            isBigger = true;
            break;
        }

        //Output
        Console.Write(currentNumber + " ");
    }

    if (isBigger)
    {
        break;
    }

    Console.WriteLine(); //Next row
}
