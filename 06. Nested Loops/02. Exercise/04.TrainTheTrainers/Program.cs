//Input
int juryCount = int.Parse(Console.ReadLine());

//Calculations
int presentationsCount = 0;
double allGradesSum = 0;
double currentGradesSum = 0;
string presentationName = "";

while ((presentationName = Console.ReadLine()) != "Finish")
{
    presentationsCount++;

	for (int i = 1; i <= juryCount; i++)
	{
		double grade = double.Parse(Console.ReadLine());
		currentGradesSum += grade;
		allGradesSum += grade;
	}

	double averageGrade = currentGradesSum / juryCount;
	currentGradesSum = 0;

    //Output
    Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
}

//Output
double averageGradeAll = allGradesSum / (presentationsCount * juryCount);
Console.WriteLine($"Student's final assessment is {averageGradeAll:f2}.");
