//Reading the Input
int bookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

//Reading Time Calculation
int readingHoursForDay = bookPages / pagesPerHour / daysToRead;

//Reading Time Output
Console.WriteLine(readingHoursForDay);