using System;
class FieldBasics
{
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.


    //static members
    static string fileName = "Ram_Resume.docx";   //filename is a field . string value.
    static string filLocation = @"D:\Students\Resumes";
    static string fileSize = "2kb";
    static string filecreatedDate = "Mar-01-2025";
    static int personAge = 25;

    static DateTime applyResumeDateAndTime = DateTime.Now;

    static void ShowMessage(string filename, string filelocation, DateTime applyResumeDateAndTime, int personAge)
    {
        //filename 
        Console.WriteLine($"Hello, File name is {fileName}\nand file location is {filelocation}\nPerson Age : {personAge}\nDAteAndtime:{applyResumeDateAndTime}");
    }



    static void Main()
    {
        string studentFileName = FieldBasics.fileName;
        //Console.WriteLine(studentFileName);

        string studentFileLocation = FieldBasics.filLocation;

        DateTime Apply = FieldBasics.applyResumeDateAndTime;

        //Console.WriteLine(Apply);

        int Age = FieldBasics.personAge;

        FieldBasics.ShowMessage(studentFileName, studentFileLocation, Apply, Age);



    }
}