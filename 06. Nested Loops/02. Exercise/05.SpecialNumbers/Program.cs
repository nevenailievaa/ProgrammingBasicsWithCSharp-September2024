// Input
int n = int.Parse(Console.ReadLine());

// Calculations
int start = 1111;
int end = 9999;

for (int i = start; i <= end; i++)
{
    bool isSpecial = true;  // Reset isSpecial for every new number
    string iAsString = i.ToString();

    for (int j = 0; j < iAsString.Length; j++)
    {
        int currentDigit = int.Parse(iAsString[j].ToString());

        // Check if the digit is 0 to avoid division by zero
        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    // Output if the number is special
    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}