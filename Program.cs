//Module 1: Register


Console.WriteLine("Register");

Console.WriteLine("Enter username: ");

string username = Console.ReadLine();

Console.WriteLine("Enter password: ");

string password = Console.ReadLine();
  

var path = @"C:\Users\USER\Downloads\registration-system-master\sample.txt";

    File.AppendAllText(path, username + " ");
    File.AppendAllText(path, "\n");
    File.AppendAllText(path, password);

//Module 2: Login
Console.WriteLine(" Login");
Console.WriteLine("username: ");
string username_login = Console.ReadLine();
Console.WriteLine("password: ");
string password_login = Console.ReadLine();

//Console.WriteLine("Enter ID");
//string identity = Console.ReadLine();

string[] lines = File.ReadAllLines(@"C:\Users\USER\Downloads\registration-system-master\reg.txt");

for (int i = 0; i < lines.Length; i++)
{
    string[] values = lines[i].Split(' ');

    if (values[0] == username_login && values[1] == password_login)
    {
        Console.WriteLine("Welcome, " + username_login);
        break;
    }
    else
    {
        Console.WriteLine("Error");
        Console.ReadLine();
    }
}
//File.AppendAllText(path, "\n");
//File.AppendAllText(path, identity);

//Module 3: 





