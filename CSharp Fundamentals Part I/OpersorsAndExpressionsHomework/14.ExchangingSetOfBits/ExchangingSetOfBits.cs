using System;
using System.Collections;


class ExchangingSetOfBits
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers so that: num is unsigned integer, p < q, q < 32 and q > p + k");
        Console.WriteLine();

        Console.Write("num = ");
        uint num = uint.Parse(Console.ReadLine());

        Console.Write("p = ");
        uint p = uint.Parse(Console.ReadLine());

        Console.Write("q = ");
        uint q = uint.Parse(Console.ReadLine());

        Console.Write("k = ");
        uint k = uint.Parse(Console.ReadLine());

        // only for test
        //uint num = 45;
        //uint p = 4;
        //uint q = 12;
        //uint k = 5;

         if (p < q && q < 32 && q > p + k)
        {
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0') + " = " + num); //to see the number in binary system

            uint[] bits = new uint[32]; //make an array for num in binary system
            for (uint i = 0; i < 32; i++)
            {
                bits[i] = num % 2;
                num /= 2;
            }

            // max value of bitsnumber in two groups
            uint maxP = p + k - 1;  
            uint maxQ = q + k - 1;

            // excanging of bits
            for (; p <= maxP && q <= maxQ; p++, q++)
            {
                uint temporari = bits[p];
                bits[p] = bits[q];
                bits[q] = temporari;
            }

            Array.Reverse(bits);

            // only for test
            //foreach (uint bit in bits)
            //{
            //    Console.Write(bit);
            //}

            double[] doubleBits = new double[32];
            doubleBits = Array.ConvertAll(bits, o => (double)(int)o);
            //Console.WriteLine();

            // only for test
            //foreach (double db in doubleBits)
            //{
            //    Console.Write(db);
            //}

            double changedNum = 0;
            double two = 0;

            for (int i = 31; i >= 0; i--)
            {       
                doubleBits[i] *= Math.Pow(2,two);
                changedNum += doubleBits[i]; 
                two++;
            }

            uint intChangedNumber = (uint)changedNum;
            Console.WriteLine(Convert.ToString(intChangedNumber, 2).PadLeft(32, '0') + " = " + intChangedNumber);
        }
        else
        {
            Console.WriteLine("Invalid numbers! It should be p < q, q < 32 and q > p + k");
        }
        
    }
}

