using System;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class MainClass
{
    private static Student[] studentArray;

    public static void Main(string[] args)
    {
        CreateArray();
        AcceptInfo();
        Console.WriteLine("Original Student Array:");
        PrintInfo();

        ReverseArray();
        Console.WriteLine("Reversed Student Array:");
        PrintInfo();
    }

    public static void CreateArray()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        studentArray = new Student[numberOfStudents];
    }

    public static void AcceptInfo()
    {
        for (int i = 0; i < studentArray.Length; i++)
        {
            studentArray[i] = new Student();

            Console.Write($"Enter ID for student {i + 1}: ");
            studentArray[i].Id = int.Parse(Console.ReadLine());

            Console.Write($"Enter name for student {i + 1}: ");
            studentArray[i].Name = Console.ReadLine();

            Console.Write($"Enter age for student {i + 1}: ");
            studentArray[i].Age = int.Parse(Console.ReadLine());
        }
    }

    public static void PrintInfo()
    {
        foreach (var student in studentArray)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    public static void ReverseArray()
    {
        int length = studentArray.Length;
        Student[] reversedArray = new Student[length];

        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = studentArray[length - 1 - i];
        }

        studentArray = reversedArray;
    }
}
