using System;


class ReadingInformationAboutCompany
{
    static void Main()
    {
        Console.WriteLine("Please fulfill this form with information about the company, where you are working");
        Console.Write("Name of the company: ");
        string companyName = Console.ReadLine();

        Console.Write("Address: ");
        string address = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Website: ");
        string website = Console.ReadLine();

        Console.Write("Full name of the manager (first and last name): ");
        string managerName = Console.ReadLine();

        Console.Write("Age of the manager: ");
        string managerAge = Console.ReadLine();

        Console.Write("Phone number of the manager: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("You can see below the entered information about your company:");

        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Phone number: {0}", phoneNumber);
        Console.WriteLine("Fax number: {0}", faxNumber);
        Console.WriteLine("Website: {0}", website);
        Console.WriteLine("Manager: {0}", managerName);
        Console.WriteLine("Age of the manager: {0}", managerAge);
        Console.WriteLine("Phone number of the manager: {0}", managerPhoneNumber);
    }
}

