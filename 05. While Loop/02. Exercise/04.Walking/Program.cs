
int walkingSteps = 0;

while (walkingSteps < 10000)
{
	string input = Console.ReadLine();

	if (input == "Going home")
	{
		int stepsToHome = int.Parse(Console.ReadLine());
		walkingSteps += stepsToHome;
		break;
	}

	int currentSteps = int.Parse(input);
	walkingSteps += currentSteps;
	
}

if (walkingSteps >= 10000)
{
	int stepsOverGoal = walkingSteps - 10000;

    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepsOverGoal} steps over the goal!");
}
else
{
	int stepsToGoal = 10000 - walkingSteps;

    Console.WriteLine($"{stepsToGoal} more steps to reach goal.");
}
