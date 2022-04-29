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
Implement a Book Library application that:
- reads and stores data in CSV files
- allows to search and borrow books
- allows to create and search users
- works as a console application, reading commands, until loop is stopped by the user

## Steps
1. Clone this repository and open main folder in IDE
1. Create a new Console application:
`dotnet new console -o Library.App`
1. Add Library.App project to the solution: `dotnet sln Library.sln add Library.App`
1. Add external project to the Library.App: `dotnet add Library.App package Library.Repositories`
1. Define required commands for the Library.App to search, borrow books, create users and exit the application
1. Implement IFileAccess interface, for CSV file access use library [CsvHelper](https://joshclose.github.io/CsvHelper/getting-started/)
1. Add Library.Data.Tests project to the solution: `dotnet sln Library.sln add Library.Data.Tests`
1. Run test to check if test for file access pass: `dotnet test Library.Data.Tests`

## Requirements
- .NET 5/6 SDK
- IDE (preffered VS Code)