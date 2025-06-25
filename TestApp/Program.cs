// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("This is a test application");

// Constants for salary components
const decimal HRA_PERCENTAGE = 0.20m;
const decimal LTA_PERCENTAGE = 0.15m;
const decimal BONUS_PERCENTAGE = 0.10m;
const decimal OTHER_COMPONENTS_PERCENTAGE = 0.25m;

// Function to calculate salary based on base salary only
static decimal CalculateSalary(decimal baseSalary)
{
    decimal hra = baseSalary * HRA_PERCENTAGE;
    decimal lta = baseSalary * LTA_PERCENTAGE;
    decimal bonus = baseSalary * BONUS_PERCENTAGE;
    decimal otherComponents = baseSalary * OTHER_COMPONENTS_PERCENTAGE;
    return baseSalary + hra + lta + bonus + otherComponents;
}

// Example usage
Console.WriteLine($"Calculated Salary: {CalculateSalary(5000)}");