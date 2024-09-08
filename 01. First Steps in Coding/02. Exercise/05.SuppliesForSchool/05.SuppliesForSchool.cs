//Prices
double penPacketPrice = 5.80;
double markerPacketPrice = 7.20;
double cleanerLiterPrice = 1.20;

//Reading the Input
int penPacketsCount = int.Parse(Console.ReadLine());
int markerPacketsCount = int.Parse(Console.ReadLine());
int cleanerLitresCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

//Bill Calculation
double bill = penPacketPrice * penPacketsCount + markerPacketPrice * markerPacketsCount +cleanerLiterPrice * cleanerLitresCount;

double billWithDiscount = bill - (bill * percentDiscount / 100);

//Final Bill Output
Console.WriteLine(billWithDiscount);