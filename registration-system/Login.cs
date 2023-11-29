using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Login
    {
       public void Start()
        {
Console.WriteLine(" You Can Now Login");
            Console.WriteLine("Enter Your Username ");
            string username_login = Console.ReadLine();

            string[] lines = File.ReadAllLines(@"C:\Users\Nancy\Desktop\my c projects\ConsoleApp3\ConsoleApp3\reg.txt");
            
            // if(i == (letters.length -1))
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(' ');

                if(i == (lines.Length - 1))
                {
                    if (values[0] != username_login)
                    {
                        Console.WriteLine("Not Found, " + username_login);
                      
                    }

                }

                    if (values[0] == username_login  )
                    {

                    Console.WriteLine("Enter Password ");
                    string password_login = Console.ReadLine();
                    if (  values[1] == password_login)
                    {
                        Console.WriteLine("Welcome, " + username_login);
                        break;
                    }
                    else {
                        Console.WriteLine("You entered a Wrong Password");
                            }
                }
 

                // jane 345
                
            }
        }
        
    }

}
