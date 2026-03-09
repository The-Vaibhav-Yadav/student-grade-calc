# Student Grade Calculator (SOLID Principles)

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![Architecture](https://img.shields.io/badge/Architecture-SOLID-orange)
![License](https://img.shields.io/badge/license-MIT-green)

A refined implementation mapping computational student grading structures utilizing C# and .NET. This project serves as a practical demonstration of **Software Design Patterns** and **SOLID Principles** (specifically the Single Responsibility Principle), ensuring the codebase is decoupled, maintainable, and highly testable.

## Table of Contents
- [Tech Stack & Architecture](#tech-stack--architecture)
- [Prerequisites](#prerequisites)
- [Installation & Local Setup](#installation--local-setup)
- [Usage & Running the App](#usage--running-the-app)
- [Testing](#testing)
- [Deployment](#deployment)
- [Contributing Guidelines](#contributing-guidelines)
- [License and Contact](#license-and-contact)

## Tech Stack & Architecture

### Core Technologies
- **Platform**: `.NET` (v8.0+)
- **Language**: `C#`
- **Pattern**: `SOLID Principles` (Single Responsibility Principle)
- **Unit Testing**: `NUnit` or `MSTest`

### High-Level Architecture
The system is partitioned into two primary projects:
1. **`StudentGradeCalc`**: The core library containing the computational business logic.
   - `GradeCalculator.cs`: A class strictly responsible for calculating numerical averages from student grade arrays, adhering precisely to SRP.
2. **`UnitTests`**: A mirrored testing project ensuring regression stability for algorithm edge cases (e.g., null arrays, empty datasets).

## Prerequisites
- **.NET SDK**: v8.0 or higher globally installed.
- **IDE**: Visual Studio 2022+, VS Code, or JetBrains Rider.

## Installation & Local Setup

```bash
git clone https://github.com/The-Vaibhav-Yadav/student-grade-calc.git
cd student-grade-calc
```

Open the solution file (`SoftwareDesignPatterns.sln`) in your preferred development environment to load all nested projects.

## Usage & Running the App

### Initializing the Calculator
Inject the grade arrays directly into the `GradeCalculator` service:

```csharp
using StudentGradeCalc;

double[] studentGrades = { 85.5, 90.0, 78.5 };
var calculator = new GradeCalculator(studentGrades);

double average = calculator.CalculateAverage();
Console.WriteLine($"Average Grade: {average}");
```

## Testing
This project emphasizes robust unit testing directly mapped to logic boundaries.

### Running Project Tests
Using the .NET CLI:
```bash
dotnet test
```
The test suite validates:
- Standard calculation accuracy.
- Zero-length array handling (returning `0` vs `null`).
- Correct parameter injection.

## Deployment
For production usage, the library can be packaged as a NuGet package (`.nupkg`) following the standard .NET build pipeline and distributed to private or public feeds.

## Contributing Guidelines
1. Follow **Microsoft C# Coding Conventions**.
2. Branch from `main`.
3. Adhere to **Conventional Commits**: `feat(logic): add weighted average support`.
4. All Pull Requests must pass the `dotnet test` CI suite.

## License and Contact
- **License**: MIT
- **Author**: Vaibhav Yadav (https://github.com/The-Vaibhav-Yadav)
