using System;

class CompanyInfo
{
    static void Main()
    {
        //input

        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string faxNum = Console.ReadLine();
        string companyWebSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        sbyte managerAge = sbyte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        //logic

        string managerFullname = managerFirstName + " " + managerLastName;
        if (faxNum == "")
        {
            faxNum = "(no fax)";
        }

        //output


        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhone);
        Console.WriteLine("Fax: " + faxNum);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFullname, managerAge, managerPhone);
    }
}