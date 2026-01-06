using System;
using System.IO;

class PasswordValidator
{
    // Folder path where accounts and commonpassword.txt are stored
    private string folderPath = @"C:\Users\kamikaze\source\repos\AccountSystemOOP\";

    // Method to check if password is valid
    public bool IsValid(string password)
    {
        // Check minimum length
        if (password.Length < 10)
        {
            Console.WriteLine("Password must be at least 10 characters long.");
            return false;
        }

        try
        {
            // Find all text files in the folder
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            // Loop through each file
            foreach (string file in files)
            {
                // Read file line by line
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // If password matches any line in the file → reject
                        if (password == line)
                        {
                            Console.WriteLine("Password is too common or already used.");
                            return false;
                        }
                    }
                }
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Folder not found: " + folderPath);
        }

        // If all checks passed → return true
        return true;
    }
}
