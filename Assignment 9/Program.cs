using System;

public class Employee
{
    public int Id { get; }
    public double Salary { get; set; }
    public string Designation { get; }
    public string Department { get; set; }

    private static int count = 0;

    public Employee()
    {
        Id = ++count;
        Salary = 0.0;
        Designation = "Manager";
        Department = "Unknown";
    }

    public Employee(double salary, string department)
    {
        Id = ++count;
        Salary = salary;
        Designation = "Employee";
        Department = department;
    }

    public void Accept()
    {
        Console.Write("Enter salary: ");
        Salary = double.Parse(Console.ReadLine());

        Console.Write("Enter department: ");
        Department = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Department: {Department}");
    }
}

public class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager() : base()
    {
    }

    public new void Accept()
    {
        base.Accept();

        Console.Write("Enter bonus: ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Bonus: {Bonus}");
    }

    public static void Main(string[] args)
    {
        Manager manager1 = new Manager();
        manager1.Accept();
        manager1.Print();
    }
}
