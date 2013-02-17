using System;

class IsGrater
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers");
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int third = 0;

        if (first > secound)
        {
            third = first;
            first = secound;
            secound = third;
            Console.WriteLine("First = {0}, secound = {1}", first, secound);
        }
        else
        {
            Console.WriteLine("First = {0}, secound = {1}", first, secound);
        }
    }
}

