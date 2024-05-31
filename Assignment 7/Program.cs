using System;

public class Date
{
    private int day;
    private int month;
    private int year;

    // Default constructor
    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    // Parameterized constructor
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Properties
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Method to accept data from the console
    public void AcceptDate()
    {
        Console.Write("Enter day: ");
        day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());
    }

    // Method to print data to the console
    public void PrintDate()
    {
        Console.WriteLine($"{day:D2}/{month:D2}/{year}");
    }

    // Method to check the validity of the date
    public bool IsValid()
    {
        if (year < 1 || month < 1 || month > 12 || day < 1)
        {
            return false;
        }

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Check for leap year
        if (month == 2 && IsLeapYear(year))
        {
            daysInMonth[1] = 29;
        }

        return day <= daysInMonth[month - 1];
    }

    // Method to check if a year is a leap year
    private bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        if (year % 100 == 0)
        {
            return false;
        }
        return year % 4 == 0;
    }

    // Method to return data of the object in string format
    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }

    // Static method to return the difference between two dates in number of years
    public static int DifferenceInYears(Date date1, Date date2)
    {
        return Math.Abs(date1.year - date2.year);
    }

    // Overload "-" operator to perform the same job
    public static int operator -(Date date1, Date date2)
    {
        return DifferenceInYears(date1, date2);
    }

    // Static method to calculate the age based on the birth date
    public static int CalculateAge(Date birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;

        if (birthDate.Month > today.Month || (birthDate.Month == today.Month && birthDate.Day > today.Day))
        {
            age--;
        }

        return age;
    }
}

public class Person
{
    private string name;
    private bool gender;
    private Date birth;
    private string address;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        gender = true; // Assuming true represents male, false represents female
        birth = new Date();
        address = "Unknown";
    }

    // Parameterized constructor
    public Person(string name, bool gender, Date birth, string address)
    {
        this.name = name;
        this.gender = gender;
        this.birth = birth;
        this.address = address;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public bool Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public Date Birth
    {
        get { return birth; }
        set { birth = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public int Age
    {
        get { return Date.CalculateAge(birth); }
    }

    // Method to accept data from the console
    public void Accept()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();

        Console.Write("Enter gender (M/F): ");
        char genderChar = char.ToUpper(Console.ReadLine()[0]);
        gender = (genderChar == 'M');

        Console.WriteLine("Enter birth date:");
        birth.AcceptDate();

        Console.Write("Enter address: ");
        address = Console.ReadLine();
    }

    // Method to print data to the console
    public void Print()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
        Console.Write("Birth Date: ");
        birth.PrintDate();
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Age: {Age}");
    }

    // Method to return data of the object in string format
    public override string ToString()
    {
        return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Birth Date: {birth}, Address: {address}, Age: {Age}";
    }

    // Main method for testing the Person class
    public static void Main(string[] args)
    {
        // Create a person object using default constructor
        Person person1 = new Person();

        // Create a person object using parameterized constructor
        Date birthDate = new Date(15, 6, 1995);
        Person person2 = new Person("John Doe", true, birthDate, "123 Main St");

        // Accept data for a new person object
        Person person3 = new Person();
        person3.Accept();

        // Print details of person objects
        person1.Print();
        person2.Print();
        person3.Print();

        // Print person details using ToString method
        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());
        Console.WriteLine(person3.ToString());
    }
}
