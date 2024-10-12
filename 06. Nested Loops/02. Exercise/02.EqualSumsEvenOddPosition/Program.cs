//Input
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

//Calculations
for (int i = firstNum; i <= secondNum; i++)
{
    string currentNumAsString = i.ToString();
    int evenNumsSum = 0;
    int oddNumsSum = 0;

    //Even and Odd Numbers Sum
    for (int j = 0; j < currentNumAsString.Length; j++)
    {
        int currentDigit = int.Parse(currentNumAsString[j].ToString());

        if (j % 2 == 0)
        {
            evenNumsSum += currentDigit;
        }
        else
        {
            oddNumsSum += currentDigit;
        }
    }

    //Output
    if (evenNumsSum == oddNumsSum)
    {
        Console.Write(i + " ");
    }
}