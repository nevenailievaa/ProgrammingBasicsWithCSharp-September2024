// Математически подход с четене на числата като int от конзолата

int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

int firstDigitStartNumber = startNumber / 1000;
int secondDigitStartNumber = startNumber / 100 % 10;
int thirdDigitStartNumber = startNumber / 10 % 10;
int fourthDigitStartNumber = startNumber % 10;

int firstDigitEndNumber = endNumber / 1000;
int secondDigitEndNumber = endNumber / 100 % 10;
int thirdDigitEndNumber = endNumber / 10 % 10;
int fourthDigitEndNumber = endNumber % 10;

for (int i = firstDigitStartNumber; i <= firstDigitEndNumber; i++)
{
    for (int j = secondDigitStartNumber; j <= secondDigitEndNumber; j++)
    {
        for (int k = thirdDigitStartNumber; k <= thirdDigitEndNumber; k++)
        {
            for (int l = fourthDigitStartNumber; l <= fourthDigitEndNumber; l++)
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