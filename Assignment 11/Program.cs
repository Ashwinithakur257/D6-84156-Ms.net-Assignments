using System;

public class Employee
{
    public string Designation { get; protected set; }

    public Employee()
    {
        Designation = "Wage";
    }
}

public class WageEmp : Employee
{
    private int hours;
    private int rate;

    // Default constructor
    public WageEmp() : base()
    {
        this.hours = 0;
        this.rate = 0;
    }

    // Parameterized constructor
    public WageEmp(int hours, int rate) : base()
    {
        this.hours = hours;
        this.rate = rate;
    }

    // Property for Hours
    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }

    // Property for Rate
    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }
    // Method to accept data from console
    public void Accept()
    {
        Console.Write("Enter hours: ");
        hours = int.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        rate = int.Parse(Console.ReadLine());
    }

    // Method to print data to console
    public void Print()
    {
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Hours Worked: {hours}");
        Console.WriteLine($"Rate per Hour: {rate}");
    }

    // Method to return data of object in string format
    public override string ToString()
    {
        return $"Designation: {Designation}, Hours Worked: {hours}, Rate per Hour: {rate}";
    }
}

public class Program
{
    public static void Main()
    {
        // Testing the WageEmp class
        WageEmp emp1 = new WageEmp();
        emp1.Accept();
        emp1.Print();
        Console.WriteLine(emp1.ToString());

        WageEmp emp2 = new WageEmp(40, 20);
        emp2.Print();
        Console.WriteLine(emp2.ToString());
    }
}


