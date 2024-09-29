//Input
int age = int.Parse(Console.ReadLine());
double washingmachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//Calculations
int toysCount = 0;
int money = 0;
int moneyIntake = 0;


for (int i = 1; i <= age; i++)
{
    if (i % 2 == 1)
    {
        toysCount++;
    }
    else
    {
        moneyIntake += 10;
        money += moneyIntake;

        //Brother takes 1lv
        money--;
    }
}

money += toysCount * toyPrice;

//Output
if (money >= washingmachinePrice)
{
    double remainingMoney = money - washingmachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double moneyLeft = washingmachinePrice - money;
    Console.WriteLine($"No! {moneyLeft:f2}");
}