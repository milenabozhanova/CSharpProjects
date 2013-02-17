using System;

class BitsExchanging
{
    static void Main()
    {
        Console.Write("Please enter an unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());

        uint mask = 7u; // 111 in binary system
        uint checkFirstBits = (mask << 3) & n; 
        uint checkSecondBits = (mask << 24) & n;
        uint firstBits = checkFirstBits >> 3;  // find out first group of bits 3,4,5
        uint secoundBits = checkSecondBits >> 24; // find out secound group of bits 24,25,26

        n = n & ~(mask << 3); //reset first bits (with 0)
        n = n & ~(mask << 24); //reset secound bits (with 0)

        n = n | (secoundBits << 3); //exchange first bits
        n = n | (firstBits << 24); //exchange secound bits

       Console.WriteLine("The exchanged number is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));  
    }
}

