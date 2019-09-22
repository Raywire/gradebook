[![Build Status](https://travis-ci.org/Raywire/gradebook.svg?branch=develop)](https://travis-ci.org/Raywire/gradebook)
### Prerequisites
-  [.NET Core SDK](https://dotnet.microsoft.com/download)

### Description
We need an electronic grade book to read the scores of an individual student and then compute some simple statistics from the scores.
The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, the lowest grade and the average grade.
### Run the project
```bash
dotnet run --project src/GradeBook 
```

### Build the project
```bash
dotnet build
```

### Install nuget packages
```bash
dotnet restore
```

### Run the tests
```bash
dotnet test
```