using System;

public class Class1
{
   
        //Login

        //  username Username = new username();
        // password Password = new password();

        string username = Console.ReadLine();
        string password = Console.ReadLine();

        // Check if the username and password are available in the file


        public void doLogin() {
            string[] lines = File.ReadAllLines(@"C:\\Users\\USER\\Desktop\\lang\\reg.txt\");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if (values[0] == username && values[1] == password)
                {
                    Console.WriteLine("Welcome, " + username);
                    break;
                }
                else
                {
                    Console.WriteLine("Username or password is incorrect.");
                }
            }
        }
    } 
        
