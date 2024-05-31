
using System;

public struct Student
{
    // Data members (private)
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    // Default constructor
    public Student()
    {
        // Default values for data members
        name = "";
        gender = false;
        age = 0;
        std = 0;
        div = ' ';
        marks = 0.0;
    }

    // Parameterized constructor
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    // Get methods
    public string GetName()
    {
        return name;
    }

    public bool GetGender()
    {
        return gender;
    }

    public int GetAge()
    {
        return age;
    }

    public int GetStd()
    {
        return std;
    }

    public char GetDiv()
    {
        return div;
    }

    public double GetMarks()
    {
        return marks;
    }

    // Set methods
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetGender(bool gender)
    {
        this.gender = gender;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void SetStd(int std)
    {
        this.std = std;
    }

    public void SetDiv(char div)
    {
        this.div = div;
    }

    public void SetMarks(double marks)
    {
        this.marks = marks;
    }

    // Accept details from console
    public void AcceptDetails()
    {
        Console.WriteLine("Enter student details:");
        Console.Write("Name: ");
        name = Console.ReadLine();

        Console.Write("Gender (true for male, false for female): ");
        gender = bool.Parse(Console.ReadLine());

        Console.Write("Age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Standard: ");
        std = int.Parse(Console.ReadLine());

        Console.Write("Division: ");
        div = char.Parse(Console.ReadLine());

        Console.Write("Marks: ");
        marks = double.Parse(Console.ReadLine());
    }

    // Print details to console
    public void PrintDetails()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Standard: " + std);
        Console.WriteLine("Division: " + div);
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object using default constructor
        Student student1 = new Student();

        // Accept details from console
        student1.AcceptDetails();

        // Print details to console
        student1.PrintDetails();
    }
}

