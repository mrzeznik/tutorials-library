# Book Library
Quick C# tutorial.

Topics: 
- data types
- debugging
- objects, methods, properties
- variables
- flow control
- project structure
- abstraction
- using packages
- LINQ
- extension methods
- error handling
- documentation
- tests

## Task
Problem: a single librarian in small book library requires an app to handle books & users management.

Implement a Book Library application that:
- reads and stores data in CSV files
- allows to add, search and borrow books
- allows to create and search users
- allows to list all currently borrowed books
- works as a console application, reading commands, until loop is stopped by the user

## Steps
1. Clone this repository and open main folder in IDE
1. Define required commands for the Library.App
1. Define application flow
1. Create a new Console application:
`dotnet new console -o Library.App`
1. Add Library.App project to the solution: `dotnet sln Library.sln add Library.App`
1. Add external project to the Library.App: `dotnet add Library.App package Library.Repositories`
1. Implement Library.Tools IFileAccess interface, for CSV file access use library [CsvHelper](https://joshclose.github.io/CsvHelper/getting-started/)
1. Add Library.Tools.Tests project to the solution: `dotnet sln Library.sln add Library.Tools.Tests`
1. Run test for file access implementation: `dotnet test Library.Tools.Tests`
1. Add main flow to the Library.App

## Requirements
- .NET 5/6 SDK
- IDE (preffered VS Code)