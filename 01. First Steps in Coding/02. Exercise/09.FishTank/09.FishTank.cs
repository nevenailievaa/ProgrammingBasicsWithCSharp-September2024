//Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

//Litres Calculation
int aquariumVolume = length * width * height; //In cubic Centimeters
double aquariumLitersVolume = aquariumVolume / 1000.0; //In Liters
double takenSpace = aquariumLitersVolume * (percent / 100);

double neededLiters = aquariumLitersVolume - takenSpace;

//Output
Console.WriteLine(neededLiters);