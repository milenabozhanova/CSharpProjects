using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int maxI = (int)Math.Pow((double)2, n) - 1;
        int counter = 0;

        for (int i = 1; i < maxI; i++)
        {
            long currentSum = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                }            
            }  
            if (currentSum == s)
                {
                    counter++;
                }
        }
        Console.WriteLine(counter);
    }
}
