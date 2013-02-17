using System;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main()
        {
            string userInput = Console.ReadLine();
            long res = 0;

            foreach (char c in userInput)
            {
                int tmp = 0;
                if (int.TryParse(c.ToString(), out tmp))
                {
                    res += tmp;
                }
            }

            while (res > 9)
            {
                int len = res.ToString().Length;
                long[] arrayOfRes = new long[len];
                int i = 0;
                while (res >= 10)
                {
                    arrayOfRes[i] = res % 10;
                    res /= 10;
                    i++;
                }
                arrayOfRes[len - 1] = res;

                res = 0;
                for (int c = 0; c < len; c++)
                {
                    res += arrayOfRes[c];
                }
            }

            Console.WriteLine(res);
        }
    }
}
