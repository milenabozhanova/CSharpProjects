using System;


class SumOfFractions
{
    static void Main()
    {
        float a = 1f;
        float even = 2f;
        float odd = 3f;
        Console.Write("{0}", a);
        float sum = 1f;

        for (int i = 0; i < 5; i++)
        {
            float evenA = (a / even);
            float oddA = ((a / odd) * -1);
            Console.Write(" + {0}/{1} - {0}/{2}", a, even, odd);
            sum += (evenA + oddA);
            even +=2;
            odd +=2;
        }
        Console.WriteLine(" = {0:F3}", sum);
    }
}

