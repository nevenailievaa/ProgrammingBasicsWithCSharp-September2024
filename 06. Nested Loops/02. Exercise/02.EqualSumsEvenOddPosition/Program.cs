//Input
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

//Calculations
for (int currentNum = firstNum; currentNum <= secondNum; currentNum++)
{
    string currentNumAsString = currentNum.ToString();
    int evenNumsSum = 0;
    int oddNumsSum = 0;

    //Even and Odd Numbers Sum
    for (int digitPosition = 0; digitPosition < currentNumAsString.Length; digitPosition++)
    {
        int currentDigit = int.Parse(currentNumAsString[digitPosition].ToString());

        if (digitPosition % 2 == 0)
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
        Console.Write(currentNum + " ");
    }
}
