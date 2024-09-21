//Input
int daysStay = int.Parse(Console.ReadLine()) -1;
string typeRoom = Console.ReadLine();
string feedback = Console.ReadLine();

//Calculations
double bill = 0;

if (typeRoom == "room for one person")
{
    bill = daysStay * 18;
}
else if (typeRoom == "apartment")
{
    bill = daysStay * 25;

    if (daysStay < 10)
    {
        bill = bill * 0.7; //30% discount
    }
    else if (daysStay >= 10 && daysStay <= 15)
    {
        bill = bill * 0.65; //35% discount
    }
    else if (daysStay > 15)
    {
        bill = bill * 0.5; //50% discount
    }
}
else if (typeRoom == "president apartment")
{
    bill = daysStay * 35;

    if (daysStay < 10)
    {
        bill = bill * 0.9; //10% discount
    }
    else if (daysStay >= 10 && daysStay <= 15)
    {
        bill = bill * 0.85; //15% discount
    }
    else if (daysStay > 15)
    {
        bill = bill * 0.8; //20% discount
    }
}

//Discount based on the Feedback
if (feedback == "positive")
{
    bill = bill * 1.25; //25% price up
}
else if (feedback == "negative")
{
    bill = bill * 0.9; //10% discount
}

//Output
Console.WriteLine($"{bill:f2}");