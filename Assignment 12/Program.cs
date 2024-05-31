using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Designation { get; protected set; }

    public Employee(int id)
    {
        Id = id;
        Designation = "Wage";
    }
}

public class WageEmp : Employee
{
    public int Hours { get; set; }
    public int Rate { get; set; }

    // Default constructor
    public WageEmp(int id) : base(id)
    {
        Hours = 0;
        Rate = 0;
    }

    // Parameterized constructor
    public WageEmp(int id, int hours, int rate) : base(id)
    {
        Hours = hours;
        Rate = rate;
    }

    public void Accept()
    {
        Console.Write("Enter hours: ");
        Hours = int.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        Rate = int.Parse(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Designation: {Designation}, Hours Worked: {Hours}, Rate per Hour: {Rate}");
    }

    public override string ToString()
    {
        return $"ID: {Id}, Designation: {Designation}, Hours Worked: {Hours}, Rate per Hour: {Rate}";
    }

    public double CalculateMonthlySalary()
    {
        return Hours * Rate;
    }
}

public class Company
{
    private string name;
    private string address;
    private LinkedList<Employee> empList;
    private double salaryExpense;

    // Default constructor
    public Company()
    {
        name = string.Empty;
        address = string.Empty;
        empList = new LinkedList<Employee>();
        salaryExpense = 0.0;
    }

    // Parameterized constructor
    public Company(string name, string address)
    {
        this.name = name;
        this.address = address;
        empList = new LinkedList<Employee>();
        salaryExpense = 0.0;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public LinkedList<Employee> EmpList
    {
        get { return empList; }
        set { empList = value; }
    }

    public double SalaryExpense
    {
        get { return salaryExpense; }
        private set { salaryExpense = value; }
    }

    // Method to accept data from console
    public void Accept()
    {
        Console.Write("Enter company name: ");
        name = Console.ReadLine();
        Console.Write("Enter company address: ");
        address = Console.ReadLine();
    }

    // Method to print data to console
    public void Print()
    {
        Console.WriteLine($"Company Name: {name}");
        Console.WriteLine($"Company Address: {address}");
        Console.WriteLine($"Total Salary Expense: {salaryExpense}");
    }

    // Method to calculate salary expense per month
    public void CalculateSalaryExpense()
    {
        salaryExpense = 0.0;
        foreach (var emp in empList)
        {
            if (emp is WageEmp wageEmp)
            {
                salaryExpense += wageEmp.CalculateMonthlySalary();
            }
        }
    }

    // Method to add employee
    public void AddEmployee(Employee e)
    {
        empList.AddLast(e);
    }

    // Method to remove employee
    public bool RemoveEmployee(int id)
    {
        var node = FindEmployee(id);
        if (node != null)
        {
            empList.Remove(node);
            return true;
        }
        return false;
    }

    // Method to find employee
    public LinkedListNode<Employee> FindEmployee(int id)
    {
        var current = empList.First;
        while (current != null)
        {
            if (current.Value.Id == id)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    // Method to return data of object in string format
    public override string ToString()

    {
        return $"Company Name: {name}, Company Address: {address}, Total Salary Expense: {salaryExpense}";
    }

    // Method to print all employees
    public void PrintEmployees()
    {
        foreach (var emp in empList)
        {
            Console.WriteLine(emp.ToString());
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a company and adding employees
        Company company = new Company("TechCorp", "123 Tech Street");
        WageEmp emp1 = new WageEmp(1, 160, 20);
        WageEmp emp2 = new WageEmp(2, 150, 22);

        company.AddEmployee(emp1);
        company.AddEmployee(emp2);

        // Calculating and printing salary expenses
        company.CalculateSalaryExpense();
        company.Print();
        company.PrintEmployees();

        // Removing an employee
        company.RemoveEmployee(1);
        company.CalculateSalaryExpense();
        company.Print();
        company.PrintEmployees();
    }
}
