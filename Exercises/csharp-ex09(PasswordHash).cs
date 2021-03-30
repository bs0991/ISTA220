using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PasswordHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------------------- PASSWORD AUTHENTICATION SYSTEM -----------------------");
                Console.WriteLine();
                Console.WriteLine("Please select one option:");
                Console.WriteLine("1.  Establish an account");
                Console.WriteLine("2.  Authenticate a user");
                Console.WriteLine("3.  Print all usernames/passwords and exit the system");
                Console.WriteLine();
                Console.Write("Enter selection: ");

                PasswordHash();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private static void PasswordHash()
        {
            int userResponse = int.Parse(Console.ReadLine());
            while (userResponse !=0)
            {
                switch (userResponse)
                {
                    case 1:
                        Util.getNewUser();
                        userResponse = Util.printUI();
                        break;
                    case 2:
                        Util.getUser();
                        userResponse = Util.printUI();
                        break;
                    case 3:
                        Util.printUsers();
                        userResponse = Util.printUI();
                        break;
                    default:
                        Console.WriteLine("Sorry, I didn't understand what you wanted to do.");
                        userResponse = Util.printUI();
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
    public static class Util
    {
        private static string newUserName, username;
        private static string newPassword, password;
        private static IDictionary<string, string> loginInfo = new Dictionary<string, string>();

        public static void getNewUser()
        {
            Console.WriteLine("Please enter your new username and password.");
            Console.Write("Username: ");
            newUserName = Console.ReadLine();
            Console.Write("Password: ");
            Console.ForegroundColor = ConsoleColor.Black;
            newPassword = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (!loginInfo.ContainsKey(newUserName))
                loginInfo.Add(new KeyValuePair<string, string>(newUserName, newPassword));
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Username {newUserName} already exists. Please enter a different username.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }

        public static void getUser()
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            Console.ForegroundColor = ConsoleColor.Black;
            password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if (!loginInfo.Contains(new KeyValuePair<string, string>(username, password)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The username and/or password you entered is incorrect. Please try again.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your username and password have been accepted.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static int printUI()
        {
            Console.WriteLine("----------------------- PASSWORD AUTHENTICATION SYSTEM -----------------------");
            Console.WriteLine();
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1.  Establish an account");
            Console.WriteLine("2.  Authenticate a user");
            Console.WriteLine("3.  Print all usernames/passwords and exit the system");
            Console.WriteLine();
            Console.Write("Enter selection: ");

            int response = int.Parse(Console.ReadLine());
            return response;
        }

        public static void printUsers()
        {
            foreach (KeyValuePair<string, string> unpw in loginInfo)
            {
                Console.WriteLine($"Username: {unpw.Key.ToString()}\nRaw Password: {unpw.Value.ToString()}");
                Console.WriteLine((DisplayHashCode(unpw.Value.ToString())));
                Console.WriteLine();
            }
        }
        public static string DisplayHashCode(string rawPassword)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
