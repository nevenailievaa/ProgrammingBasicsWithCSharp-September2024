//Input
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

//Calculations
//Minutes
if (minutes >= 45) //14:47 -> 14:62 -> 15:02
{
    hours++; //++ -> Добавяме 1 към променливата
    minutes = (minutes + 15) % 60;
}
else
{
    minutes += 15; //Вместо minutes = minutes + 15; изписваме minutes += 15; -> Така се добавя стойност по-кратко към дадена промнелива
}

//Hours
if (hours == 24) //23:47 -> 0:02
{
    hours = 0;
}

//Output
if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}
