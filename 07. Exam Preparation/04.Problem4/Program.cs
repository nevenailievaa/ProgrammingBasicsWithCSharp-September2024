// Input and Calculations
int countOfDays = int.Parse(Console.ReadLine());
double amountOfAllFood = double.Parse(Console.ReadLine());

double allEatenFoodFromDog = 0;
double allEatenFoodFromCat = 0;
double cookies = 0;

for (int day = 1; day <= countOfDays; day++)
{
    int eatenDogFoodThisDay = int.Parse(Console.ReadLine());
    int eatenCatFoodThisDay = int.Parse(Console.ReadLine());

    allEatenFoodFromDog += eatenDogFoodThisDay;
    allEatenFoodFromCat += eatenCatFoodThisDay;

    if (day % 3 == 0)
    {
        double eatenFoodThisDay = eatenDogFoodThisDay + eatenCatFoodThisDay;
        double cookiesThisDay = eatenFoodThisDay * 0.1;
        cookies += cookiesThisDay;
    }
}

double eatenFoodFromDogAndCat = allEatenFoodFromDog + allEatenFoodFromCat;

double percentEatenFood = eatenFoodFromDogAndCat / amountOfAllFood * 100;
double percentEatenFoodFromDog = allEatenFoodFromDog / eatenFoodFromDogAndCat * 100;
double percentEatenFoodFromCat = allEatenFoodFromCat / eatenFoodFromDogAndCat * 100;

Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");
Console.WriteLine($"{percentEatenFoodFromDog:F2}% eaten from the dog.");
Console.WriteLine($"{percentEatenFoodFromCat:F2}% eaten from the cat.");