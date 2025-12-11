using System;
 class Method_Returntype
{
    static void Main()
    {
        // we can print the value in deferent ways by calling method in  diffrent ways....
        string Username = TextMethod();
        Console.WriteLine(Username);
        Console.WriteLine($"Method is called by using String intapulation techneque return value is : {TextMethod()}");

        // int return type

        int UserAge = getUserAge();
        Console.WriteLine(UserAge);
        Console.WriteLine($"Method is called by using String intapulation techneque return value is : {getUserAge()}");

        // boolan return type

        bool UserStetus = IsEqual();
        Console.WriteLine(UserStetus);

        // Array return type...


        string[] UserDitailes = getUserDitailes();
        foreach (string UserDT in UserDitailes)
        {
            Console.WriteLine(UserDT);

        }

        Console.WriteLine($"UserName:{UserDitailes[0]}\nUserAge:{UserDitailes[1]}\nUserStatus:{UserDitailes[2]}");
    }
    // method with string return type
    static string TextMethod()
    {
        return "Raju";
    }
    // method with int return type

    static int getUserAge()
    {
        return 25;
    }
    static bool IsEqual()
    {
        string stetus = "UnMarried";


        if (stetus == "UnMarried")
        {

            Console.WriteLine($"User  is : {stetus}");
            return true;
        }
        else if (stetus == "Married")
        {
            Console.WriteLine($"User  is : {stetus}");
            return true;
        }
        else
        {
            Console.WriteLine($"User stetus is Not Mentioned : {stetus}");
            return false;
        }

    }
    static string[] getUserDitailes()
    {
        string[] UserDitailes = new string[] { "Raju", "25", "UnMarried" };

        return UserDitailes;

    }


}

