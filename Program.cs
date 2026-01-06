using AccountSystemOOP;
using System;
// Creating a console based account registation & login system
class Program
{
    static void Main()   // Main method = starting point of the program
    {
        // Create a PasswordValidator object (for checking passwords)
        PasswordValidator pv = new PasswordValidator();

        // Create an AccountManager object and pass PasswordValidator into it
        AccountManager accountManager = new AccountManager(pv);

        // Infinite loop (keeps showing menu until user chooses Exit)
        while (true)
        {
            Console.WriteLine("\n1. Register");  // Option 1: Register
            Console.WriteLine("2. Login");      // Option 2: Login
            Console.WriteLine("3. Exit");       // Option 3: Exit program
            Console.Write("Choose an option: "); // Ask user for choice
            string choice = Console.ReadLine();  // Read user input

            // Use switch-case to decide action
            switch (choice)
            {
                case "1":  // If user chooses 1 → call Register()
                    accountManager.Register();
                    break;

                case "2":  // If user chooses 2 → call Login()
                    accountManager.Login();
                    break;

                case "3":  // If user chooses 3 → exit program
                    return;

                default:   // If user enters wrong choice
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
