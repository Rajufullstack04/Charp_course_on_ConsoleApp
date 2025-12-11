using System;
 class ConditionalStatementes
{
    static void Main()
    {
        // if Statement
        // else if Statement
        // else Statement

        string BankAccount = "CANARA";  // Not SBI, not HDFC, not IDFC

        if (BankAccount == "SBI")
        {
            Console.WriteLine($"You Have Account In: {BankAccount}");
        }
        else if (BankAccount == "HDFC")
        {
            Console.WriteLine($"You Have Account In: {BankAccount}");
        }
        else if (BankAccount == "IDFC")
        {
            Console.WriteLine($"You Have Account In: {BankAccount}");
        }
        else
        {
            Console.WriteLine($"You Don't Have Account In: {BankAccount}");
        }


        // Switch Case--------------------------------------------------------------------

        // it executes statements based on the case .....


        string Application = "..";

        switch (Application)
        {
            case "PUBG":
                Console.WriteLine($"You have  Open the GamingApplication: {Application} ");
                break;

            case "FaceBook":
                Console.WriteLine($"You have  Open the SocialMediaApplication: {Application} ");
                break;

            case "PhonePay":
                Console.WriteLine($"You have  Open the PaymentApplication: {Application} ");
                break;

            case "Amazon":
                Console.WriteLine($"You have  Open the ShopingApplication: {Application} ");
                break;

            default:
                Console.WriteLine($"You Din't  Open any Application: {Application} ");
                break;
        }



    }

}

