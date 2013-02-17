using System;

class ReadAndCalculateNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integer separated by spaces");
        string numbers = Console.ReadLine();
        //numbers = numbers.Trim();
        
        string[] numbersArr = numbers.Split(' ');

        int sum = 0;

        for (int i = 0; i < numbersArr.Length; i++)
        {
            sum += int.Parse(numbersArr[i]);
        }

        Console.WriteLine(sum);
    }
}
