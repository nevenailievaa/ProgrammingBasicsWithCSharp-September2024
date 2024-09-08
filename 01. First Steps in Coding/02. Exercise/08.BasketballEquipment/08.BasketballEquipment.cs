//Input
int yearBasketBallFee = int.Parse(Console.ReadLine());

//Fees Calculation
double shoesPrice = yearBasketBallFee - (yearBasketBallFee * 0.4);
double equipmentPrice = shoesPrice - (shoesPrice * 0.2);
double basketBallPrice = equipmentPrice / 4;
double accessoriesPrice = basketBallPrice / 5;

double bill = yearBasketBallFee + shoesPrice + equipmentPrice + basketBallPrice + accessoriesPrice;

//Output
Console.WriteLine(bill);