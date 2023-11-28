Console.WriteLine("REgister");

Console.WriteLine("Enter username: ");

string username = Console.ReadLine();

Console.WriteLine("Enter password: ");

string password = Console.ReadLine();

    

var path = @"C:\Users\USER\Desktop\lang\reg.txt";


    File.AppendAllText(path, username + " ");
    File.AppendAllText(path, password);
    File.AppendAllText(path, "\n");









Console.WriteLine(" Login");
Console.WriteLine("username: ");
string username_login = Console.ReadLine();
Console.WriteLine("password: ");
string password_login = Console.ReadLine();

string[] lines = File.ReadAllLines(@"C:\\Users\\USER\\Desktop\\lang\\reg.txt");

for (int i = 0; i < lines.Length; i++)
{
    string[] values = lines[i].Split(' ');

    if (values[0] == username_login && values[1] == password_login)
    {
        Console.WriteLine("Welcome, " + username_login);
        break;
    }
}




