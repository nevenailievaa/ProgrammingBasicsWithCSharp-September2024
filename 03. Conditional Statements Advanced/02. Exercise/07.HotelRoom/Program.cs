//Input
string month = Console.ReadLine();
int daysStay = int.Parse(Console.ReadLine());

//Calculations
double studioPrice = 0;
double apartmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apartmentPrice = 65;

    if (daysStay > 7 && daysStay <= 14)
    {
        studioPrice = studioPrice * 0.95; //5% discount
    }
    else if (daysStay > 14)
    {
        studioPrice = studioPrice * 0.7; //30% discount
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;

    if (daysStay > 14)
    {
        studioPrice = studioPrice * 0.8; //20% discount
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    apartmentPrice = 77;
}

if (daysStay > 14)
{
    apartmentPrice = apartmentPrice * 0.9; //10% discount
}

double studioBill = daysStay * studioPrice;
double apartmentBill = daysStay * apartmentPrice;

//Output
Console.WriteLine($"Apartment: {apartmentBill:f2} lv.");
Console.WriteLine($"Studio: {studioBill:f2} lv.");