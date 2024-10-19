// Подход с четене на числата като string от конзолата

string startNumber = Console.ReadLine(); 
string endNumber = Console.ReadLine();   

int firstDigitStartNumber = int.Parse(startNumber[0].ToString()); 
int secondDigitStartNumber = int.Parse(startNumber[1].ToString()); 
int thirdDigitStartNumber = int.Parse(startNumber[2].ToString()); 
int fourthDigitStartNumber = int.Parse(startNumber[3].ToString());

int firstDigitEndNumber = int.Parse(endNumber[0].ToString()); 
int secondDigitEndNumber = int.Parse(endNumber[1].ToString()); 
int thirdDigitEndNumber = int.Parse(endNumber[2].ToString()); 
int fourthDigitEndNumber = int.Parse(endNumber[3].ToString()); 

for (int i = firstDigitStartNumber; i <= firstDigitEndNumber; i++)
{
    for (int j = secondDigitStartNumber; j <= secondDigitEndNumber; j++)
    {
        for (int k = thirdDigitStartNumber; k <= thirdDigitEndNumber; k++)
        {
            for(int l = fourthDigitStartNumber; l <= fourthDigitEndNumber; l++)
            {
                // Проверяваме дали всички итератори са нечетни
                if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                }
            }
        }
    }
}