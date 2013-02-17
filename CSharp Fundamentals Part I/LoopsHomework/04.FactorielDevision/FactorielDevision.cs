using System;

class FactorielDevision
{
    static void Main()
    {
        checked
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());

            if (n > 1 && n < k)
            {
                int factorialK = 1;
                for (int i = (n + 1); i <= k; i++)
                {
                    factorialK *= i;
                }
                Console.WriteLine("N!/K!= {0}", (1.0 / factorialK));
            }
            else
            {
                Console.WriteLine("Error: n should be smaller than k and n sould be bigger than 0.");
            }
        }
    }
}
