# Account Registration System

A small **C# console application** demonstrating object-oriented programming, account registration, password validation, and a basic file-based login flow.

## Overview

The program separates account operations into an `AccountManager` class and password checks into a `PasswordValidator` class. Registration creates a local text file for the username; login reads the saved record and compares the supplied credentials.

## Features

- Console-based registration and login
- Password validation through a dedicated validator class
- Check for an existing username file before registration
- Local file-based account records
- Basic success and error messages

## Technology

- C#
- .NET / Visual Studio project
- Object-oriented programming
- .NET file I/O

## Main files

| File | Purpose |
| --- | --- |
| `Program.cs` | Application entry point and menu flow |
| `AccountManager.cs` | Registration and login operations |
| `PasswordValidator.cs` | Password validation rules |
| `account.cs` | Account-related class |
| `App.config` | Application configuration |

## Run locally

1. Install Visual Studio with the .NET desktop development workload.
2. Clone the repository:
   ```bash
   git clone https://github.com/pyatrick666/AccountRegistrationSystem.git
   ```
3. Open `AccountSystemOOP.sln` in Visual Studio.
4. Review the storage path in `AccountManager.cs` and change it to a writable folder on your computer.
5. Build and run the project.

## Important security note

This is an introductory learning exercise, **not a production authentication system**. The current implementation writes passwords as plain text in local files and uses a machine-specific storage path. Do not use it to store real credentials. A production version should use a suitable password-hashing algorithm with a unique salt, safer storage, and appropriate account protections.

## Learning goals

- Classes and object-oriented design
- Separating validation from account operations
- Console input and output
- Reading and writing local files
- Basic registration and login workflows

## Author

**Pratik Poudel** · [GitHub](https://github.com/pyatrick666)
