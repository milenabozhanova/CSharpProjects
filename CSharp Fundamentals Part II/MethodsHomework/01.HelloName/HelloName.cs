using System;

class HelloName
{
    static void PrintHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    
    
    static void Main()
    {
        Console.WriteLine("Please write your name");
        string name = Console.ReadLine();

        PrintHello(name);
    }
}

