using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating 4 students
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        // Creating a Dictionary for the gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        // Check if "Tom" has a record and add if not
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Calculate average GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"Average GPA: {averageGPA:F2}");

        // Print information about students with GPA greater than average
        Console.WriteLine("Students with GPA greater than average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook[student.GetName()] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}

// Extension method to get the student name (not part of original requirement but necessary for accessing names)
public static class StudentExtensions
{
    public static string GetName(this Student student)
    {
        var field = typeof(Student).GetField("studentName", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        return (string)field.GetValue(student);
    }
}
