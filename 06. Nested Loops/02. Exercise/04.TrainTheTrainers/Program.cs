//Input
int juryCount = int.Parse(Console.ReadLine());

//Calculations
string presentationName = "";
int presentationsCount = 0;
double allGradesSum = 0;
double currentGradesSum = 0;

while ((presentationName = Console.ReadLine()) != "Finish")
{
    presentationsCount++;

    for (int j = 1; j <= juryCount; j++)
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
Console.WriteLine($"Student's final assessment is {allGradesSum / (presentationsCount * juryCount):f2}.");