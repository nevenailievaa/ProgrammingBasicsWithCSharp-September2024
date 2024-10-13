//Input
int n = int.Parse(Console.ReadLine());

//Calculations
for (int currentNum = 1111; currentNum <= 9999; currentNum++)
{
    bool isSpecial = true;
    string currentNumAsString = currentNum.ToString();

    for (int j = 0; j < currentNumAsString.Length; j++)
    {
        int currentDigit = int.Parse(currentNumAsString[j].ToString());

        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    //Output
    if (isSpecial)
    {
        Console.Write(currentNum + " ");
    }
}
