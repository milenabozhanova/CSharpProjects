using System;

namespace DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string dancers = string.Empty;
            int res = 0;


            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                dancers += Convert.ToString(input, 2);
            }

            if (dancers.Length > 0)
            {
                char lastBit = dancers[0];
                int followCnt = 1;
                for (int i = 1; i < dancers.Length; i++)
                {
                    if (lastBit == dancers[i])
                    {
                        followCnt++;
                    }
                    else
                    {
                        if (followCnt == k)
                        {
                            res++;
                        }
                        lastBit = dancers[i];
                        followCnt = 1;
                    }
                }
                if (followCnt == k)
                {
                    res++;
                }
            }

            Console.WriteLine(res);
        }
    }
}
