// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("This is a test application");

// Function to calculate salary based on base salary only
static decimal CalculateSalary(decimal baseSalary)
{
    decimal hra = baseSalary * 0.20m;
    decimal lta = baseSalary * 0.15m;
    decimal bonus = baseSalary * 0.10m;
    decimal otherComponents = baseSalary * 0.25m;
    return baseSalary + hra + lta + bonus + otherComponents;
}

// Example usage
Console.WriteLine($"Calculated Salary: {CalculateSalary(5000)}");