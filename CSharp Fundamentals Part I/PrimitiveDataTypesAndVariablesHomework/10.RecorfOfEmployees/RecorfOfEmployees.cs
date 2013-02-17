using System;

class RecorfOfEmployees
{
    static void Main()
    {
        Console.WriteLine("Please fulfill this form for our record");
        Console.Write("Please write your first name:");
        string firstName = Console.ReadLine();

        Console.Write("Please write your family name:");
        string familyName = Console.ReadLine();

        Console.Write("Please write your age:");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Please write your gender. (For male write: M, for female: F): ");
        string gender = Console.ReadLine();

        Console.Write("Please write your ID number:");
        uint idNumber = uint.Parse(Console.ReadLine());

        Console.Write("Please write your personal employee number:");
        uint employeeNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine("Your personal epmloyee card is:");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Family name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);


        if (gender == "M")
        {
            Console.WriteLine("Gender: Male");
        }
        else if (gender == "F")
        {
            Console.WriteLine("Gender: Female");
        }
        else
        {
            Console.WriteLine("The answer for your gender is incorrect");
        }

        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Personal employee number: {0}", employeeNumber);
    }
}
