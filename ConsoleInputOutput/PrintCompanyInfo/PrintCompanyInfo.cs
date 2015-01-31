/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and 
 * prints it back on the console.*/

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        Console.Write("Company fax number: ");
        int companyFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        int managerPhoneNumber = int.Parse(Console.ReadLine());
       
        Console.Clear();
        
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Phone number: " + companyPhoneNumber);
        Console.WriteLine("Fax number: " + companyFaxNumber);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager: " + managerFirstName + "" + managerLastName);
        Console.WriteLine("Age: " + managerAge);
        Console.WriteLine("Phone number: " + managerPhoneNumber);
    }
}

