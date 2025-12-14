//using System;
//using System.Collections;

//namespace Csharp_Dec_Step4
//{
//    class HashtableExample
//    {
//        static void Main()
//        {
//            // Create a Hashtable
//            Hashtable employees = new Hashtable();

//            // Add key-value pairs
//            employees.Add(101, "Alice");
//            employees.Add(102, "Bob");
//            employees.Add(103, "Charlie");

//            // Access value by key
//            Console.WriteLine($"Employee with ID 102: {employees[102]}");

//            // Iterate through hashtable
//            Console.WriteLine("\nEmployee List:");
//            foreach (DictionaryEntry entry in employees)
//            {
//                Console.WriteLine($"Key {entry.Key} : Value {entry.Value}");
//            }

//            // Check if a key exists
//            bool has104 = employees.ContainsKey(104);
//            Console.WriteLine($"\nContains key 104? {has104}");

//            // Check if a value exists
//            bool hasAlice = employees.ContainsValue("Alice");
//            Console.WriteLine($"Contains value 'Alice'? {hasAlice}");

//            // Update a value
//            employees[103] = "Charlie Updated";

//            Console.WriteLine("\nAfter Update:");
//            foreach (DictionaryEntry entry in employees)
//            {
//                Console.WriteLine($"Key {entry.Key} : Value {entry.Value}");
//            }

//            // Remove an entry
//            employees.Remove(102);

//            Console.WriteLine("\nAfter Removing Key 102:");
//            foreach (DictionaryEntry entry in employees)
//            {
//                Console.WriteLine($"Key {entry.Key} : Value {entry.Value}");
//            }

//            // Count
//            Console.WriteLine($"\nTotal Employees: {employees.Count}");
//        }
//    }
//}
using System;
using System.Collections;


namespace Csharp_Dec_Step4
{
    class HashtableExample
    {
        static void Main()
        {

            Hashtable studentdetails = new Hashtable();
            studentdetails.Add("bhanu", "selected");
            studentdetails.Add(1, "rollnumber");
            studentdetails.Add("bhanu@2808", "Gmail");
            foreach (DictionaryEntry d in studentdetails)
            {
                Console.WriteLine("Key: " + d.Key + "  Value: " + d.Value);
            }

            //Console.WriteLine(studentdetails);

        }

    }
}




