
int firstPlayerEggs = int.Parse(Console.ReadLine());
int secondPlayerEggs = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "End")
{
    if (input == "one")
    {
        secondPlayerEggs--;

        if (secondPlayerEggs == 0)
        {
            Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
            break;
        }
    }
    else if (input == "two")
    {
        firstPlayerEggs--;

        if(firstPlayerEggs == 0)
        {
            Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
            break;
        }
    }

    input = Console.ReadLine();
}

if (input == "End")
{
    Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
    Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
}