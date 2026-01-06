/*using System;
using System.IO;

namespace AccountSystemOOP
{
    // Represents a user account (username + password)
    class Account
    {
        // Properties (read-only from outside, set only inside class)
        public string Username { get; private set; }
        public string Password { get; private set; }

        // Constructor to initialize an account
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Save account data into a file named after the username
        public void SaveToFile()
        {
            // StreamWriter writes text into a new file or overwrites old one
            using (StreamWriter sw = new StreamWriter(Username + ".txt"))
            {
                sw.WriteLine(Password);  // store password in file
            }
        }

        // Load password back from file (for login verification)
        public static string LoadPassword(string username)
        {
            string fileName = username + ".txt";

            try
            {
                // Open file and read the first line (the password)
                using (StreamReader sr = new StreamReader(fileName))
                {
                    return sr.ReadLine(); // return stored password
                }
            }
            catch
            {
                // If file not found or error occurs → return null
                return null;
            }
        }
    }
}
*/