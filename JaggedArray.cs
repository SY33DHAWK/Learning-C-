using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize the jagged array
        int[][][] grades = new int[3][][];

        // CSE Department
        grades[0] = new int[2][];
        grades[0][0] = new int[] { 85, 90, 78 }; // Grades for OOP2
        grades[0][1] = new int[] { 88, 92, 81 }; // Grades for TOC

        // EEE Department
        grades[1] = new int[2][];
        grades[1][0] = new int[] { 76, 84, 89 }; // Grades for PL1
        grades[1][1] = new int[] { 91, 79, 85 }; // Grades for EM1

        // BBA Department
        grades[2] = new int[2][];
        grades[2][0] = new int[] { 82, 75, 88 }; // Grades for MKT
        grades[2][1] = new int[] { 80, 83, 77 }; // Grades for Finance

        // Print all grades
        PrintAllGrades(grades);

        // Calculate and display average grade for each course
        CalculateAverageGrade(grades);

        // Calculate and display highest grade in each department
        CalculateHighestGrade(grades);
    }

    // Method to print all grades
    static void PrintAllGrades(int[][][] grades)
    {
        string[] departments = { "CSE", "EEE", "BBA" };
        string[][] courses = {
            new string[] { "OOP2", "TOC" },
            new string[] { "PL1", "EM1" },
            new string[] { "MKT", "Finance" }
        };

        Console.WriteLine("All Grades:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(departments[i] + " Department:");
            for (int j = 0; j < grades[i].Length; j++)
            {
                Console.Write("  " + courses[i][j] + ": ");
                Console.WriteLine(string.Join(", ", grades[i][j]));
            }
        }
    }

    // Method to calculate and display average grade for each course
    static void CalculateAverageGrade(int[][][] grades)
    {
        string[] departments = { "CSE", "EEE", "BBA" };
        string[][] courses = {
            new string[] { "OOP2", "TOC" },
            new string[] { "PL1", "EM1" },
            new string[] { "MKT", "Finance" }
        };

        Console.WriteLine("\nAverage Grades:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(departments[i] + " Department:");
            for (int j = 0; j < grades[i].Length; j++)
            {
                double average = grades[i][j].Average();
                Console.WriteLine($"  {courses[i][j]}: {average:F2}");
            }
        }
    }

    // Method to calculate and display highest grade in each department
    static void CalculateHighestGrade(int[][][] grades)
    {
        string[] departments = { "CSE", "EEE", "BBA" };

        Console.WriteLine("\nHighest Grades in Each Department:");
        for (int i = 0; i < grades.Length; i++)
        {
            int highest = grades[i].SelectMany(x => x).Max();
            Console.WriteLine($"{departments[i]} Department: {highest}");
        }
    }
}
