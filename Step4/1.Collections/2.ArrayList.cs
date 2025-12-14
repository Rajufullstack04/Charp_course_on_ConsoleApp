using System;
using System.Collections;

namespace CsharpCourse_DataStructures
{
    class ArrayListStudents
    {
        static void Main()
        {
            ArrayList students = new ArrayList();

            // Add student names (string) and scores (int)
            students.Add("Raju");
            students.Add(85);
            students.Add("Priya");
            students.Add(92);
            students.Add("Arjun");
            students.Add(78);

            Console.WriteLine("Initial Student List:");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // Access and cast score
            int priyaScore = (int)students[3];
            Console.WriteLine("\nPriya's Score: " + priyaScore);

            // Update Arjun's score
            students[5] = 88;

            // Remove Raju's name
            students.Remove("Raju");

            Console.WriteLine("\nUpdated Student List:");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}