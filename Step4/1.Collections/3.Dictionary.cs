using System;
using System.Collections.Generic;

namespace Csharp_Dec_Step4
{
    class EmployeeDictionaryExample
    {
        static void Main()
        {
            // Dictionary with EmployeeID (int) as Key and EmployeeName (string) as Value
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding employees
            employees.Add(101, "Alice");
            employees.Add(102, "Bob");
            employees.Add(103, "Charlie");

            // Accessing a value by key
            string empName = employees[102];  // Bob
            Console.WriteLine($"Employee with ID 102: {empName}");

            // Iterating through dictionary
            Console.WriteLine("\nEmployee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID {emp.Key} : Name {emp.Value}");
            }

            // Check if a key exists
            bool isDavidExists = employees.ContainsValue("David");
            Console.WriteLine($"\nIs David in employees? {isDavidExists}");

            // Update an employee name
            employees[103] = "Charlie Updated";

            Console.WriteLine("\nAfter Update:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID {emp.Key} : Name {emp.Value}");
            }

            // Remove an employee
            bool isRemoved = employees.Remove(102); // removes Bob
            Console.WriteLine($"\nWas Bob removed? {isRemoved}");

            Console.WriteLine("\nFinal Employee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID {emp.Key} : Name {emp.Value}");
            }

            // Dictionary with Department as Key and Employee Count as Value
            Dictionary<string, int> departments = new Dictionary<string, int>();
            departments.Add("HR", 5);
            departments.Add("IT", 10);
            departments.Add("Finance", 3);

            Console.WriteLine("\nDepartments:");
            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.Key}: {dept.Value} employees");
            }

            // Update department count
            departments["IT"] = 12;

            Console.WriteLine("\nUpdated Departments:");
            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.Key}: {dept.Value} employees");
            }
        }
    }
}