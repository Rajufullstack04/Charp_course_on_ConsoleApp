using System;
using System.Collections.Generic;

namespace Csharp_List_Example2
{
    class StudentGrades
    {
        static void Main()
        {
            // Create a list of student grades (integers)
            List<int> grades = new List<int>() { 85, 90, 78, 92 };

            // Add new grades
            grades.Add(88);
            grades.Add(76);

            Console.WriteLine("Original Grades:");
            Console.WriteLine(string.Join(", ", grades));

            // Update a grade (change index 2 → 78 to 80)
            grades[2] = 80;

            // Insert a grade at a specific position
            grades.Insert(1, 95);

            Console.WriteLine("\nAfter Updates:");
            Console.WriteLine(string.Join(", ", grades));

            // Remove a grade
            grades.Remove(76); // removes first occurrence of 76

            Console.WriteLine("\nAfter Removing 76:");
            Console.WriteLine(string.Join(", ", grades));

            // Check if a grade exists
            bool has90 = grades.Contains(90);
            Console.WriteLine($"\nContains 90? {has90}");

            // Sort grades in ascending order
            grades.Sort();
            Console.WriteLine("\nSorted Grades:");
            Console.WriteLine(string.Join(", ", grades));

            // Reverse the list (descending order)
            grades.Reverse();
            Console.WriteLine("\nDescending Grades:");
            Console.WriteLine(string.Join(", ", grades));

            // Count of grades
            Console.WriteLine($"\nTotal Grades: {grades.Count}");
        }
    }
}