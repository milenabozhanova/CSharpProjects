using System;

class Problem4_WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int[] reverseNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            char[] snum = Convert.ToString(numbers[i], 2).ToCharArray();
            Array.Reverse(snum);
            reverseNumbers[i] = Convert.ToInt32(new string(snum), 2);
        }


        foreach (var num in reverseNumbers)
        {
            Console.WriteLine(num); 
        }

    }
}

