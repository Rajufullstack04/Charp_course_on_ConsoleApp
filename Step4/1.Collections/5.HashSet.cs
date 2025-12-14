using System;
using System.Collections.Generic;

namespace Csharp_Dec_Step4
{
    class HashSetExample
    {
        static void Main()
        {
            // Create a HashSet of integers
            HashSet<int> numbers = new HashSet<int>();

            // Add elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(20); // duplicate, will be ignored
            numbers.Add(40);

            Console.WriteLine("Numbers in HashSet:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Check if a value exists
            bool has30 = numbers.Contains(30);
            Console.WriteLine($"\nContains 30? {has30}");

            // Remove a value
            numbers.Remove(10);

            Console.WriteLine("\nAfter Removing 10:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Union example
            HashSet<int> otherNumbers = new HashSet<int>() { 30, 40, 50, 60 };
            numbers.UnionWith(otherNumbers);

            Console.WriteLine("\nAfter UnionWith otherNumbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Intersection example
            HashSet<int> intersectNumbers = new HashSet<int>() { 40, 50 };
            numbers.IntersectWith(intersectNumbers);

            Console.WriteLine("\nAfter IntersectWith {40, 50}:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Count
            Console.WriteLine($"\nTotal elements: {numbers.Count}");
        }
    }
}