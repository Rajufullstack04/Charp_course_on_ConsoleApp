using System;
 class ConsoleReadLine
    {
    static void Main()
    {
        //Console ReadLine 
        // whenaver we will give the input values it will be capture by using ReadLine
        // compiler Read your value 
        // In genrally input value type accepets the String only ---  its not accept ather values like bool,char,decimal,doubal,int ....


        Console.WriteLine("Pless Enter User Name ?");
        string name = Console.ReadLine();
        Console.WriteLine($"User name is:{name}");


        Console.WriteLine("Pless Enter User PassWord");
        string password = Console.ReadLine();
        //Console.WriteLine($"User Password IS:{password}");


        Console.WriteLine("Pless Conform User PassWord");
        string ConfromPW = Console.ReadLine();
        //Console.WriteLine($"User Confromed paasword  IS:{ConfromPW}");


        bool isEqal = password.Equals(ConfromPW);
        Console.WriteLine($"User Confromed paasword  IS:{isEqal}");

        Console.WriteLine("Enter Your Loc Pincode  Here.");
        int pincode = int.Parse(Console.ReadLine());
        Console.WriteLine(pincode);


        Console.WriteLine("Enter Your Gender");
        char Gender = char.Parse(Console.ReadLine());
        Console.WriteLine(Gender);

        string alldata = string.Format("Name:{0}\n Password :{1}\n ConfromPW : {2}\n pincode:{3}\n Gender:{4}", name, password, ConfromPW, pincode, Gender);

        Console.WriteLine(alldata);
    }

}

