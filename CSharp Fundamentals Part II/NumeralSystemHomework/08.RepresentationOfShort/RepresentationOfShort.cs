using System;
using System.Collections.Generic;

class RepresentationOfShort
{
    static List<int> ConvertToBinary(int number)
    {
        List<int> binaryN = new List<int>();

        while (number > 0)
        {
            binaryN.Add(number % 2);
            number /= 2;
        }

        binaryN.Reverse();

        return binaryN;
    }
    
    
    static void Main()
    {
        Console.Write("Please enter a integer number in range -32 768 to 32 767: ");
        int number = int.Parse(Console.ReadLine());

        List<int> binaryN = new List<int>();

        if (number < 0)
        {
            number = 32768 + number;
            binaryN = ConvertToBinary(number);
            
            //make the left bit 1 for negative
            binaryN.Insert(0,1);

            // make the bits 16 
            int realCap = 16 - binaryN.Count;
            while (realCap > 0)
            {
                binaryN.Insert(1, 0);
                realCap--;
            }
   
        }
        else
        {
            binaryN = ConvertToBinary(number);

            //make the left bit 0 for positive
            binaryN.Insert(0, 0);

            // make the bits 16 
            int realCap = 16 - binaryN.Count;
            
            while (realCap > 0)
            {
                binaryN.Insert(1, 0);
                realCap--;
            }
        }

        //print
        Console.Write("The binary representation of the given short is: ");
        foreach (var bit in binaryN)
        {
            Console.Write(bit);
        }
        Console.WriteLine();

    }

  
}
