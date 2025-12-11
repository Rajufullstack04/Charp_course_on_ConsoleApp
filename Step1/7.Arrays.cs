using System;
class Arrays
    {
    static void Main()
    {
        string[] SubjectName = new string[3];
        SubjectName[0] = "English";
        SubjectName[1] = "Telugu";
        SubjectName[2] = "Hindi";
        // but here we didn't assign anther values becse we tack here only 3 values in array 
        //SubjectName[3] = "kanada"; //it will  give the run time expation


        Console.WriteLine(SubjectName[0]);
        Console.WriteLine(SubjectName[1]);
        Console.WriteLine(SubjectName[2]);


        //Console.WriteLine(SubjectName[3]);    //it will  give the run time expation ...becse we tack here only 3 values in array // we 



        // we have anther way to declar the arry values by using below sentax...

        string[] StudentNames = new string[] { "raju", "bhanu", "ravi", "venky" };

        Console.WriteLine(StudentNames[0]);
        Console.WriteLine(StudentNames[1]);
        Console.WriteLine(StudentNames[2]);
        Console.WriteLine(StudentNames[3]);


        // array length 
        // we can get whataver data you want to get in the given array by using length 

        // now i want to see the least array value only -- we cn see that also

        Console.WriteLine(StudentNames[StudentNames.Length - 2]);    // by this synax i will get the value "ravi"

        // it well print revers data


        // and also we can replace the values also ...

        string[] SubjectNames1 = new string[] { "Eng", "Tel", "Hin", "Tamil" };


        SubjectNames1[3] = "kanada";
        //Console.WriteLine(SubjectNames1[3]); // it will replace the value "thamil" to " kanada

        Console.WriteLine(SubjectNames1[0]); // eng
        Console.WriteLine(SubjectNames1[1]); // tel
        Console.WriteLine(SubjectNames1[2]); // hin
        Console.WriteLine(SubjectNames1[3]); // kanada

        // by using foreach we can print all values at a time.

        foreach (string AllSubjects in SubjectNames1)
        {
            Console.WriteLine(AllSubjects);
        }


    }

}

