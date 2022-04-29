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
1. Clone this repository

1. Create a new Console application:
`dotnet new console -o Library.App`

1. Add external project to the main App: `dotnet add Library.App package Library.Repositories`

1. Implement IFileAccess interface for file access, one using [CsvHelper](https://joshclose.github.io/CsvHelper/getting-started/)

## Requirements
- .NET 5/6 SDK
- IDE (preffered VS Code)