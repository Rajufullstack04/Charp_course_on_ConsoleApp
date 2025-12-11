using System;
 class Method_params
{
    static void Main()
    {
        PrintID(1244);
        string empName = getEmpNameByID(1);
        Console.WriteLine(empName);
       string empN = getName1();
        Console.WriteLine(empN);
        getResult("Raju",25,"Banglor");

    }


    static void PrintID(int ID)
    {
        Console.WriteLine(ID);
    }

    static string getEmpNameByID(int ID)
    {
        if (ID == 1)
        {
            return "John";
        }
        else if (ID == 2)
        {
            return "ram";
        }
        else if (ID == 3)
        {
            return "Sam";
        }
        else
        {
            return "NO NAme";
        }
    }



    //var you cannot pass as parameter
    static string getName(dynamic ID)
    {
        return "JOhn";
    }


    //var you cannot pass as parameter
    static dynamic getName1()
    {
        return "venky";
    }


    static int getResult(string param1, int param2, string param3)
    {
        Console.WriteLine(param1);
        Console.WriteLine(param2);
        Console.WriteLine(param3);
        return 108;
    }



}



