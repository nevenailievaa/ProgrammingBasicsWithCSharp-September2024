//Input
string studentName = Console.ReadLine();

//Calculations
double gradesSum = 0;
int expelsCount = 0;
int yearsCount = 0;

while (expelsCount < 2 && yearsCount < 12)
{
    double grade = double.Parse(Console.ReadLine());
    yearsCount++;

    //Expelled
    if (grade < 4)
    {
        expelsCount++;
        continue;
    }
    //Expelled
    else
    {
        gradesSum += grade;
    }
}

//Output
if (expelsCount == 2)
{
    Console.WriteLine($"{studentName} has been excluded at {yearsCount-1} grade");
}
else
{
    double averageGrade = gradesSum / yearsCount;
    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
}