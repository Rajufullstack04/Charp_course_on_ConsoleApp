using System;
 class Operators
// understand the beheviar of the operator
{
    static void Main()
    {
        // "operators" are special symbols used to perform operations on variables and values, such as arithmetic, comparison, assignment, and more.

        //  ArthamaticOperators--------------------------



        //  +  Addition
        // - Subtraction
        // * Multiplication
        //  / Division
        // % Modulus(remainder)


        int a = 5;
    int b = 10;
    int c = a + b;
    Console.WriteLine(c);

        int d = a - b;
    Console.WriteLine(d);

        int e = a * b;
    Console.WriteLine(e);
        int f = a / b;
    Console.WriteLine(f);

        int g = a % b;
    Console.WriteLine(g);

        // Comparison Operators-------------------(it gives true or false values )-----

        //Used to compare values:

        //      == Equal to
        //     != Not equal to
        //     >  Greater than
        //     <  Less than
        //     >=  Greater than or equal to
        //     <=  Less than or equal to


        bool isEqual = 10 == 10;
    Console.WriteLine(isEqual);

        bool isEqual2 = 10 != 10;
    Console.WriteLine(isEqual2);

        bool isEqual3 = 18 > 10;
    Console.WriteLine(isEqual3);


        bool isEqual4 = 18 < 20;
    Console.WriteLine(isEqual4);


        bool isEqual5 = 18 >= 18;
    Console.WriteLine(isEqual5);


        bool isEqual6 = 18 <= 10;
    Console.WriteLine(isEqual6);

        


        //        Logical Operators-----------------

        //Used with boolean expressions:


        //  && Logical AND
        //  || Logical OR
        //   ! Logical NOT

        // ---   LOGICAL && -----
        // T-T = T
        // T-F = F 
        // F-T = F
        // F-F = F


        a = 10; 
         b = 10;
         c = 10;
        bool isResult = (a == b) && (b == c);
    Console.WriteLine($"Logical AND : {isResult}");

        bool isResult1 = (a != b) && (b != c);
    Console.WriteLine($"Logical AND : {isResult1}");


        // logcal  or ||----------------------------

        // T-T = T
        // T-F = T 
        // F-T = T
        // F-F = F


        a = 20;
        b = 20;
        c = 20;
        bool isResult2 = (a == b) || (b == c);
    Console.WriteLine($"Logical AND : {isResult2}");

        bool isResult3 = (a != b) || (b != c);
    Console.WriteLine($"Logical AND : {isResult3}");


        // LOGICAL NOT !-------------
        Console.WriteLine("-----------logical NOT ---!-----");
        bool isResult4 = !(10 == 10);
    Console.WriteLine(isResult4);

        bool isResult5 = !(20 == 10);
    Console.WriteLine(isResult5);

    }

}

