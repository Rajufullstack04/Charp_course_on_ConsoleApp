using System;
 class TypeConverstion
    {
    static void Main()
    {
        //type conversion is called it converts one type to anther type is called type conversion 
        //we have two types of type conversion
        //1. Implicit type conversion
        // 2.Explicit type conversion

        
        // Explicity type 
        //in this we give the guidence to the compiler exacctly what is the type i.e. we want to convert

        int age = 25;
        string name = "raju";
        double salary = 45000.50; // we are telling the data types here in explicitly manner


        // Explicity type conversion-------------------------------------------------------------------------------

        // exp1

        double price = 12345.255;
        int amount = (int)price;// here we will Costing manually by mentioning the data type (int)---->this is called costing


        // when we are goimg to convert Explicitily we loose some value 

        Console.WriteLine(amount);// we will get amount like 12345 only we loose the .255 value here 


        // exp2

        long Number = 122434566768;
        byte byte1 = (byte)Number;
        Console.WriteLine(byte1);// we get some byte nuber here 

        // when we are going to do Explicity converstion We should be carfull . In this case we loos the data or value .






        //-----------------------------------------------------------------------------------------------------------------------------------------



        // Implicit type

        //here your compiler understand the type automatically
        // and also it understand the value you assign to the variable

        var age1 = 25; // here compiler thinks that age is integer value we no need add data type here 

        var name1 = "venky";  // here compiler thinks that name1 is string value we no need add data type here 


        // Implicit type Converstion

        // IT happendes automattyically without loosing data 

        // and also you don't need apply costing here .


        int number = 50;
        double Result = number;
        Console.WriteLine(number);// int -to-> Double --- 50 output

        byte byte2 = 255;
        int value = byte2;
        Console.WriteLine(byte2);


        int value2 = 464444445;
        long result2 = value2;
        Console.WriteLine(result2);

        float pi = 3.555F;
        double value3 = pi;
        Console.WriteLine(value3);


        // Boxing & unBoxing


        // Boxing 
        // convert the value type to refrence type is called  boxing. 

        // value type is nothing but acutual values (real values).

        // Reference type is it Store any data or values : object,String , array,,class ....

        // Ref type --> stores the Address of the acutula data .


        // boxing Exp----------------------------

        int RoomNo = 25; // here RoomNo  Acutual value (value type)
        object obj = RoomNo;// we are converting to  the refreal vaule object is ref value 
        Console.WriteLine($"Boxing int to obj :{obj}");




        // here we are converting   value type --to--> Refreal value -- it is called Boxing 

        // UnBoxing Exp-------------------------------------------------

        //ref ValueTuple --to--> value type 

        object obj2 = 14;
        int RoomNo2 = (int)obj2;// in unboxing  we use costing to convert value 
        Console.WriteLine($"Unboxing obj to int :{RoomNo2}");

        string name3 = "raju";
        string str1 = (string)name3;
        Console.WriteLine($"Unboxing sring to sring :{str1}");






    }

}

