using System;
 class StringMoreConsepts
    {
    static void Main()
    {

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";
        //myProjectPath.Length
        Console.WriteLine(myProjectPath.Length); //31


        string name1 = "raju";   //4
        int lengt = name1.Length;             //4
        Console.WriteLine(lengt); //4

        string name2 = "raju";
        string uName2 = name2.ToUpper(); // "RAJU" 
        Console.WriteLine(uName2);

        string name3 = "RaJu";
        string uName3 = name3.ToLower(); // "raju"  
        Console.WriteLine(uName3);


        // now we use Trim() method

        string name4 = "   venky    ";
        string uName4 = name4.Trim();// "raju"
        Console.WriteLine(uName4);

        // we can allso trime specal caraters also 

        string name5 = "*****venky******";
        string uName5 = name5.Trim('*');// "raju"
        Console.WriteLine(uName5);

        // Calling Trim() method by passing the * argument.

        string name6 = "****RAJU****";
        string uName6 = name6.TrimStart('*');  //RAJU****
        Console.WriteLine($"uName6 : {uName6}");



        string name7 = "****VENKY****";
        string uName7 = name7.TrimEnd('*');
        Console.WriteLine($"uName7 :{uName7}");//****VENKY



        // Adding Spaces to the string 
        // using padleft & padright methods.

        string name8 = "RAVI";
        string uName8 = name8.PadLeft(5);// padlift 5Spaces and data value
        Console.WriteLine(uName8);

        string name9 = "RAVI";
        string uName9 = name9.PadRight(5);// padright 5Spaces and data value
        Console.WriteLine(uName9);

        // And we can also add Charecters to the value by useing same mathods and passiing argumentes with in the method 

        string name10 = "Adarsh";
        string uName10 = name10.PadLeft(10, '@');   //@@@@Adarsh here 10 is total carcters 
        Console.WriteLine(uName10);


        string name11 = "Adarsh";
        string uName11 = name11.PadRight(10, '@');   //Adarsh@@@@ here 10 is total carcters 
        Console.WriteLine(uName11);


        // Equal method

        string userID = "RA1430";
        //String conformUserID = "VE1330"; // it will give false
        String conformUserID = "RA1430";
        bool isEquals = userID.Equals(conformUserID); // true
        Console.WriteLine(isEquals);


        // Sub String method


        string Sentence = "Hi Sir, I'm not feeling well and have been suffering from typhoid for the past few days.";

        string sentence1 = Sentence.Substring(8);
        Console.WriteLine(sentence1);             //I'm not feeling well and have been suffering from typhoid for the past few days.


        // we can adjust lenth also passing arguments


        string sentence2 = Sentence.Substring(8, 20);  // I'm not feeling well 
        Console.WriteLine(sentence2);


        // Replace method 

        string sentence3 = Sentence.Replace("typhoid", "Viral Fever");  // typhoid  will replace by the viral fever
        Console.WriteLine(sentence3);


        //  Format 


        int EMP = 12; //12 employes
        decimal EmpSalary = 600000;
        decimal finalOuput = EMP * EmpSalary;


        //Client message : "Hey Boos ... You are having the 10 Empolyes and total emp salary is 60000 * total employes ";

        string message = string.Format("Hey Boos ... You are having the {0} Empolyes and total EMP's Salary You Spent  {1}",
                                                      EMP, finalOuput);

        Console.WriteLine(message);





    }
}

