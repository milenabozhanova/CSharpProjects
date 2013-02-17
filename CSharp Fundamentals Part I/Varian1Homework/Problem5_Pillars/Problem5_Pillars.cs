using System;

class Problem5_Pillars
{
    static void Main()
    {
        byte[] numbers = new byte[8];
        int countExeption = 0;

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
            if (numbers[i] == 0 || numbers[i] == 128)
            {
                countExeption++;
            }
        }

        byte[] columns = new byte[8];

        if(countExeption == 8)
        {
            Console.WriteLine(7);
            Console.WriteLine(0);
            return;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < columns.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = numbers[i] & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    columns[j]++;
                }
            }
        }

        int failSum = 0;
        for (int pillar = 6; pillar >= 0; pillar--)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int leftColumns = pillar+1; leftColumns <= 7; leftColumns++)
            {
                leftSum += columns[leftColumns];
            }
            for (int rightColumns = pillar - 1; rightColumns >=0; rightColumns--)
            {
                rightSum += columns[rightColumns];
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(leftSum);
                break;
            }
            else
            {
                failSum++;
            }
        }

        if (failSum > 6)
        {
            Console.WriteLine("No");
        }
    }
}

