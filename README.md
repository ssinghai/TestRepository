# TestApp

This is a simple C# console application that demonstrates salary calculation based on a base salary input.

## Features
- Calculates total salary using base salary and standard components:
  - HRA: 20% of base salary
  - LTA: 15% of base salary
  - Bonus: 10% of base salary
  - Other Components: 25% of base salary
- Outputs the calculated salary to the console.

## Getting Started

1. Clone the repository:
   ```sh
   git clone <repository-url>
   ```
2. Open the project in Visual Studio or VS Code.
3. Build and run the application.

## Usage

Update the `Program.cs` file to change the base salary value as needed:

```csharp
Console.WriteLine($"Calculated Salary: {CalculateSalary(5000)}");
```

## Requirements
- .NET SDK 6.0 or later

## License
This project is licensed under the MIT License.
