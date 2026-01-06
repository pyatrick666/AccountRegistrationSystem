using System;
using System.IO;

namespace AccountSystemOOP
{
    // This class handles Register & Login features
    class AccountManager
    {
        private PasswordValidator validator; // To validate passwords
        private string folderPath = @"C:\Users\kamikaze\source\repos\AccountSystemOOP\";

        // Constructor: requires PasswordValidator object
        public AccountManager(PasswordValidator pv)
        {
            validator = pv;
        }

        // REGISTER NEW ACCOUNT
        public void Register()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Validate password before saving
            if (!validator.IsValid(password))
                return;

            string filePath = Path.Combine(folderPath, username + ".txt");

            // Check if user already exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            // Save username and password into a new file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);
            }

            Console.WriteLine("Account registered successfully.");
        }
        // LOGIN TO EXISTING ACCOUNT
        public void Login()
        {
            Console.Write("Enter username: ");
            // Read what the user types and store it in the variable 'username'
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            // Read what the user types and store it in the variable 'password'
            string password = Console.ReadLine();

            // Build the file path for this user's file: folderPath + "username.txt"

            string filePath = Path.Combine(folderPath, username + ".txt");


            try
            {
                // Open the file for reading. 'using' ensures the file is closed automatically.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read the first line of the file (we stored username there when registering)
                    string storedUsername = sr.ReadLine();
                    // Read the second line of the file (we stored password there when registering)
                    string storedPassword = sr.ReadLine();


                    if (storedUsername == username && storedPassword == password)
                    {
                        Console.WriteLine("Login successful!");
                    }
                    else
                    {
                        // If either the username or password does not match → failure.
                        Console.WriteLine("Invalid username or password.");
                    }
                } // StreamReader is disposed here (file gets closed)
            }
            catch (FileNotFoundException)
            {
                // This runs if the file for that username doesn't exist.
                Console.WriteLine("Account does not exist.");
            }
        }
    }
}
