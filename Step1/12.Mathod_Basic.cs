using System;
class Method_Basic
{

    static void Main()
    {
        // collection of statements.
        // executes as a single unit.

        //Entry point Main

        // i can call method inside of the Main Method

        AllMethods();

        Console.WriteLine("Main Method firid....!!");
        Console.WriteLine("ALL Method's are  firid....!!");

    }

    //Void - Non-return type
    //Void - Non-return type
    static void TestMethod1()
    {
        Console.WriteLine("1st Method Fired !!");
    }

    //Void - Non-return type
    static void TestMethod2()
    {
        Console.WriteLine("2nd Method Fired !!");
    }


    //Void - Non-return type
    static void AllMethods()
    {
        TestMethod1();
        TestMethod2();
    }


}
