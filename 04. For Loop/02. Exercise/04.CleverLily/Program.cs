//Input
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//Calculations
double money = 0;
int moneyIntake = 10;
int toysCount = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        money += moneyIntake;
        moneyIntake += 10;

        //Brother takes 1lv
        money -= 1;
    }
    else 
    { 
        toysCount++;
    }
}

money += toysCount * toyPrice;

//Output
if (money >= washingMachinePrice)
{
    double remainingMoney = money - washingMachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double moneyLeft = washingMachinePrice - money;
    Console.WriteLine($"No! {moneyLeft:f2}");
}