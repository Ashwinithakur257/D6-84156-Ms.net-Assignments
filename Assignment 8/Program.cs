using System;

public class Employee
{
    public int Id { get; }  // Employee ID
    public double Salary { get; set; }  // Employee salary
    public string Designation { get; set; }  // Employee designation
    public string Department { get; set; }  // Employee department

    private static int count = 0;  // Counter for generating auto-incremented IDs

    // Default constructor
    public Employee()
    {
        Id = ++count;  // Auto-increment ID
        Salary = 0.0;  // Default salary
        Designation = "Unknown";  // Default designation
        Department = "Unknown";  // Default department
    }

    // Parameterized constructor
    public Employee(double salary, string designation, string department)
    {
        Id = ++count;  // Auto-increment ID
        Salary = salary;
        Designation = designation;
        Department = department;
    }

    // Method to accept employee data
    public void Accept()
    {
        Console.Write("Enter salary: ");
        Salary = double.Parse(Console.ReadLine());

        Console.Write("Enter designation: ");
        Designation = Console.ReadLine();

        Console.Write("Enter department: ");
        Department = Console.ReadLine();
    }

    // Method to print employee data
    public void Print()
    {
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Department: {Department}");
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee();  // Create employee using default constructor
        emp1.Accept();  // Accept employee data
        emp1.Print();  // Print employee data

        Employee emp2 = new Employee(50000, "Manager", "HR");  // Create employee using parameterized constructor
        emp2.Print();  // Print employee data
    }
}
