using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());
        uint[] numbers = new uint[n];
 
        uint[] bitsCounter = new uint [n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());

            if (b == 1)
            {
                for (int j = 0; j < 32; j++)
                {
                    uint mask = (uint)1 << j;
                    uint nAndMask = numbers[i] & mask;
                    uint bit = nAndMask >> j;
                    if (bit == b)
                    {
                        bitsCounter[i]++;
                    }
                }
            }

            else  if (b == 0)
            {
                // find the first 1 from left to right
                uint bitNull = 0;
                int index = 31;
                while(bitNull == 0)
                {
                    uint maskNull = (uint)1 << index;
                    uint nAndMaskNull = numbers[i] & maskNull;
                    bitNull = nAndMaskNull >> index;
                    index--;
                }
                
                // check how many are the searching b in the number
                for (int j = 0; j < index+1 ; j++)
                {
                    uint mask = (uint)1 << j;
                    uint nAndMask = numbers[i] & mask;
                    uint bit = nAndMask >> j;
                    if (bit == b)
                    {
                        bitsCounter[i]++;
                    }
                }
            }
        }

        foreach (var bits in bitsCounter)
        {
            Console.WriteLine(bits);
        }

    }
}
