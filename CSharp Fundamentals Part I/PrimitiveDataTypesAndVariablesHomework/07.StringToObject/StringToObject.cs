using System;

class StringToObject
{
    static void Main()
    {
        string firstWord = "Hello";
        string secoundWord = "World";

        object greeting = firstWord + ", " + secoundWord;
        Console.WriteLine(greeting);

        string castObject = (string)greeting;
        Console.WriteLine(castObject);
    }
}
