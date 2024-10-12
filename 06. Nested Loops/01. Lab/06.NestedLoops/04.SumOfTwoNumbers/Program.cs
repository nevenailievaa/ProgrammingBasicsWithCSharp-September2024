
int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int counter = 0;
bool isFound = false;

for (int i = startNum; i <= endNum; i++)
{
    for (int j = startNum; j <= endNum; j++)
    {
        counter++;

        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
            isFound = true;
            break;
        }
    }

    if (isFound)
        break;
}

if (!isFound)
{
    Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
}