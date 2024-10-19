// Input
double strawberryPricePerKg = double.Parse(Console.ReadLine());
double amountBananas =  double.Parse(Console.ReadLine());
double amountOranges = double.Parse(Console.ReadLine());
double amountRaspberry =  double.Parse(Console.ReadLine());
double amountStrawberry = double.Parse(Console.ReadLine());

// Calculations
double raspberryPricePerKg = strawberryPricePerKg / 2;
double orangesPricePerKg = raspberryPricePerKg * 0.6;
double bananaPricePerKg = raspberryPricePerKg * 0.2;

double strawberryFinalPrice = strawberryPricePerKg * amountStrawberry;
double bananaFinalPrice = bananaPricePerKg * amountBananas;
double orangesFinalPrice = orangesPricePerKg * amountOranges;
double raspberryFinalPrice = raspberryPricePerKg * amountRaspberry;

double finalPrice = strawberryFinalPrice + bananaFinalPrice + orangesFinalPrice + raspberryFinalPrice;

// Output
Console.WriteLine($"{finalPrice:F2}");