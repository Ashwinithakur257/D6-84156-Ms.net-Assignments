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

    // Main method for testing the Date class
    public static void Main(string[] args)
    {
        // Create date objects using parameterized constructor
        Date date1 = new Date(15, 6, 2000);

        // Create a date object and accept the second date manually
        Date date2 = new Date();
        date2.AcceptDate();

        // Print dates
        date1.PrintDate();
        date2.PrintDate();

        // Check validity
        Console.WriteLine("Date 1 is valid: " + date1.IsValid());
        Console.WriteLine("Date 2 is valid: " + date2.IsValid());

        // Print dates as strings
        Console.WriteLine("Date 1: " + date1.ToString());
        Console.WriteLine("Date 2: " + date2.ToString());

        // Calculate difference in years
        int diffYears = Date.DifferenceInYears(date1, date2);
        Console.WriteLine("Difference in years (static method): " + diffYears);

        // Calculate difference in years using operator overload
        diffYears = date1 - date2;
        Console.WriteLine("Difference in years (operator overload): " + diffYears);
    }
}
