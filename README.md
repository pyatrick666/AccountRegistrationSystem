# Account Registration System

A small **C# console application** demonstrating object-oriented programming, account registration, login flow, file handling, and basic password validation.

## Overview

The program presents a menu that lets a user register an account, attempt to log in, or exit. Account details are stored in individual text files, and a separate password validator checks a minimum password length and compares passwords against text-file contents.

This is an educational project, not a production authentication system.

## Features

- Console menu for registration, login, and exit
- Account registration with duplicate-username checks
- Login by comparing entered credentials with the saved account file
- Password length validation (minimum 10 characters)
- Basic checks against passwords found in local text files
- Separate classes for account management and password validation

## Technology

- C#
- .NET Framework 4.7.2
- Visual Studio solution and project files
- File I/O using System.IO

## Project structure

```text
AccountRegistrationSystem/
├── AccountSystemOOP.sln
├── AccountSystemOOP.csproj
├── Program.cs
├── AccountManager.cs
├── PasswordValidator.cs
├── account.cs
├── App.config
└── common passwords.txt
```

## Run locally

1. Install Visual Studio with .NET Framework 4.7.2 developer tools.
2. Clone the repository:
   ```bash
   git clone https://github.com/pyatrick666/AccountRegistrationSystem.git
   cd AccountRegistrationSystem
   ```
3. Open AccountSystemOOP.sln in Visual Studio.
4. Review the account storage directory configured in AccountManager.cs and PasswordValidator.cs; update the hard-coded local Windows path for your machine.
5. Build and run the project.

## Security limitations

This project is for learning and should **not** be used to store real accounts or passwords.

- Passwords are currently written to text files in plain text.
- Login compares the entered password directly with the stored text.
- The account storage path is hard-coded to a local Windows directory.
- The password checks are basic and do not replace a secure password-hashing and authentication design.

A future version should use a configurable data directory, salted password hashing (for example, a suitable password-hashing library), safer input handling, and automated tests.

## Author

**Pratik Poudel**

[GitHub profile](https://github.com/pyatrick666) · [Professional portfolio](https://pyatrick666.github.io/Professional-Portfolio/)
