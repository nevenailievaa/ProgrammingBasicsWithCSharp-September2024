//Input
string username = Console.ReadLine();
string password = Console.ReadLine();

//Password Check
string passwordInput = Console.ReadLine();

while (passwordInput != password)
{
    passwordInput = Console.ReadLine();
}

//Output
Console.WriteLine($"Welcome {username}!");