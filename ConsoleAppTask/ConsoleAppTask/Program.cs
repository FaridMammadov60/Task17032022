using ConsoleAppTask.Model;
using System;
using System.Text.RegularExpressions;

namespace ConsoleAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username enter: ");
            string username=Console.ReadLine();
            Console.WriteLine("Password enter: ");
            string password=Console.ReadLine();
            Console.WriteLine("Age enter: ");
            int age=Convert.ToInt32(Console.ReadLine());    
            
            User user = new User(username, password)
            {
                Age =age
            };

            ///Console.WriteLine(user);
        }
    }
}
