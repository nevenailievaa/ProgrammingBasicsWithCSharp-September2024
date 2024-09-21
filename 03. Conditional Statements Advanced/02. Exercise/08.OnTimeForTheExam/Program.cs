//Input
int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int studentHour = int.Parse(Console.ReadLine());
int studentMinute = int.Parse(Console.ReadLine());

int examTimeInMinutes = examHour * 60 + examMinute;
int studentTimeInMinutes = studentHour * 60 + studentMinute;

//Calculations
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
else //On Time or Early
{
    int minutesBefore = examTimeInMinutes - studentTimeInMinutes;
    
    if (minutesBefore == 0) //Exactly On Time
    {
        Console.WriteLine("On time");
    }
    else if (minutesBefore <= 30) //On Time
    {
        Console.WriteLine("On time");
        Console.WriteLine($"{minutesBefore} minutes before the start");
    }
    else //Early
    {
        Console.WriteLine("Early");

        int hoursBefore = minutesBefore / 60;
        minutesBefore = minutesBefore % 60;

        if (hoursBefore == 0 && minutesBefore < 60)
        {
            Console.WriteLine($"{minutesBefore} minutes before the start");
        }
        else if (minutesBefore < 10)
        {
            Console.WriteLine($"{hoursBefore}:0{minutesBefore} hours before the start");
        }
        else
        {
            Console.WriteLine($"{hoursBefore}:{minutesBefore} hours before the start");
        }
    }
}