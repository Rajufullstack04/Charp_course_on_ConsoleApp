using System;
using System.Linq;
class Looping_Mechanisam
{
    static void Main()
    {

        // C# offers several looping mechanisms to execute code repeatedly based on conditions or collections.
        // These include
        // for,
        // foreach,
        // while,
        // do-while loops.


        // While-----

        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("While is Executed.....!");
            count++;
        }
        Console.WriteLine("After Execution.....");


        // Do-While----------------
        int result = 0;
        do
        {
            Console.WriteLine("Do-While is Executed....!");
            result++;
        }
        while (result < 5);




        //foreach----------------------
        string[] frutsAndVegetabules = new string[] { "Mango", "Apple", "Banana", "Grapes", "Tomato", "Mircchi", "Garlic" };

        // Define a list of known vegetables
        string[] vegetables = new string[] { "Tomato", "Mircchi", "Garlic" };

        foreach (string Fitems in frutsAndVegetabules)
        {
            //Console.WriteLine(items);

            // we only want to print the lenth of 6 charcters items names 
            if (Fitems.Length == 5)
            {
                Console.WriteLine($"Five Charecter items in frutsAndVegetabules :{Fitems}");
            }

            if (vegetables.Contains(Fitems))
            {
                Console.WriteLine(Fitems);
            }


        }
        // For loop-----------------------------------------------------
        // - You know exactly how many times you want to repeat a block of code. you can use a for loop.

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number is :" + i);
        }




    }

}

