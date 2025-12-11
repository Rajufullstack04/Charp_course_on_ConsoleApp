using System;
 class StringExampule 
    {
    static void Main()
    {
        string coursename = "Csharp";

        Console.WriteLine(coursename);

        string uCourseName = "\"Csharp\"";
        Console.WriteLine(uCourseName); // "Csharp"

        string lStatus = "one \n two \n three";
        Console.WriteLine(lStatus); //  new line

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath); // D:\Csharp_Nov\MyFirstConsoleApp

        string myProjectPath1 = @"D:\Csharp_Nov\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath1); //  D:\Csharp_Nov\MyFirstConsoleApp

        string sName = "Mery";
        int age = 15;

        //string interpolaiton technique
        string studentDetails = $"Student name : {sName} \nStudent age : {age} ";
        Console.WriteLine(studentDetails);

        //${ }
    }
}

