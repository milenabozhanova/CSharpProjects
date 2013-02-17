using System;

class FactorielNK
{
    static void Main()
    {
        checked
        {
            Console.Write("n = ");
            double n = int.Parse(Console.ReadLine());

            Console.Write("k= ");
            double k = int.Parse(Console.ReadLine());

            if (n > 1 && n < k)
            {
                
                // factoriel N!
                double factorialN = 1;
                for (double i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }

                // factoriel K! is form (K - N + 1) to K; (K-N)! in the denominator is direct reduced
                double factorialKN = 1;
                for (double i = (k - n + 1); i <= k; i++)
                {
                    factorialKN *= i;
                }
                Console.WriteLine("(N!*K!)/(K-N)!= {0}", (factorialN * factorialKN));
            }
            else
            {
                Console.WriteLine("Error: n should be smaller than k and n sould be bigger than 0.");
            }
        }
    }
}

