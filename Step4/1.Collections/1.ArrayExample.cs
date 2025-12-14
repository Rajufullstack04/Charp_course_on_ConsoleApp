//using System;


//namespace Csharp_Collections
//{
//    class ArrayExample
//    {
//        static void Main()
//        {
//            // Declare a fixed-size array of 5 integers
//            int[] numbers = new int[5];

//            // Assign values
//            numbers[0] = 10;
//            numbers[1] = 20;
//            numbers[2] = 30;
//            numbers[3] = 40;
//            numbers[4] = 50;

//            // Trying to add beyond size will cause error
//            // numbers[5] = 60; //  IndexOutOfRangeException we will find here

//            // Iterate through the array
//            Console.WriteLine("Array elements:");
//            foreach (int num in numbers)
//            {
//                Console.WriteLine(num);
//            }

//            // Access by index
//            Console.WriteLine($"First element: {numbers[0]}");
//            Console.WriteLine($"Last element: {numbers[numbers.Length - 2]}");


//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpCourse_DataStructures
{
    class ArrayExample
    {
        static void Main()
        {
            FixedSizeArray();
        }

        static void FixedSizeArray()
        {
            int[] numbers = new int[4]; //Fixed size

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            //numbers[4] = 50; // runtime error expeciotn i.e. argement out of range excepitons..



            //numbers.ad

            //some scenerio
            numbers[0] = 50;  // you can do

            Console.WriteLine(numbers);


            int indexOf30 = Array.IndexOf(numbers, 30);   //

            Console.WriteLine(indexOf30);


            int SecondValue = numbers[1];   // No need the any cast...
            Console.WriteLine(SecondValue);
        }
    }
}