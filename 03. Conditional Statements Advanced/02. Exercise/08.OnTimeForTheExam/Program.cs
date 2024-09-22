//Input
int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int studentHour = int.Parse(Console.ReadLine());
int studentMinutes = int.Parse(Console.ReadLine());

//Calculations
int examTimeInMinutes = examHour * 60 + examMinutes;
int studentTimeInMinutes = studentHour * 60 + studentMinutes;

if (examTimeInMinutes < studentTimeInMinutes) //Late
{
    Console.WriteLine("Late");
    int minutesLate = studentTimeInMinutes - examTimeInMinutes;

    if (minutesLate < 60)
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else
    {
        int hoursLate = minutesLate / 60;
        minutesLate = minutesLate % 60;

        if (minutesLate < 10)
        {
            Console.WriteLine($"{hoursLate}:0{minutesLate} hours after the start");
        }
        else
        {
            Console.WriteLine($"{hoursLate}:{minutesLate} hours after the start");
        }
    }
}
else
{
    int minutesBefore = examTimeInMinutes - studentTimeInMinutes;

    if (minutesBefore == 0) //Exactly on time
    {
        Console.WriteLine("On time");
    }
    else if (minutesBefore <= 30) //Up to 30 minutes before the start
    {
        Console.WriteLine("On time");
        Console.WriteLine($"{minutesBefore} minutes before the start");
    }
    else //Early
    {
        Console.WriteLine("Early");

        int hoursBefore = minutesBefore / 60;
        minutesBefore = minutesBefore % 60;

        if (hoursBefore == 0 && minutesBefore < 60) //Early 31 to 59 minutes before the start
        {
            Console.WriteLine($"{minutesBefore} minutes before the start");
        }
        else if (minutesBefore < 10) //Early above 1 hour before the start
        {
            Console.WriteLine($"{hoursBefore}:0{minutesBefore} hours before the start");
        }
        else
        {
            Console.WriteLine($"{hoursBefore}:{minutesBefore} hours before the start");
        }
    }
}
