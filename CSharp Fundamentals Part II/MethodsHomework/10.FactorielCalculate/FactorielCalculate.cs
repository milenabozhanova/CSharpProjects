using System;

class FactorielCalculate
{
     static void Main()
        {
            int[] res = new int[1] { 1 };
            for (int f = 2; f <= 100; f++)
            {
                res = Multiply(res, IntToArray(f));
            }

            Array.Reverse(res);
            Console.WriteLine(string.Join("", res).TrimStart('0'));
        }

        static int[] IntToArray(int p)
        {
            int len = 1;
            if (p > 9)
            {
                len = 2;
            }
            if (p > 99)
            {
                len = 3;
            }

            int[] res = new int[len];

            for (int i = 0; i < len; i++)
            {
                res[i] = p % 10;
                p = p / 10;
            }

            return res;
        }

        static int[] Multiply(int[] num1, int[] num2)
        {
            int[] res = new int[num1.Length + num2.Length];

            for (int i = 0; i < num2.Length; i++)
            {
                int[] mul = Multiply(num1, num2[i]);

                for (int x = 0; x < mul.Length; x++)
                {
                    res[i + x] += mul[x];
                    CheckOverflow(res, i + x);
                }
            }

            return res;
        }

        static int[] Multiply(int[] num1, int num2)
        {
            int[] res = new int[num1.Length + 1];

            for (int i = 0; i < num1.Length; i++)
            {
                int mul = num1[i] * num2;
                res[i] += mul % 10;
                CheckOverflow(res, i);

                res[i + 1] += mul / 10;
                CheckOverflow(res, i + 1);
            }

            return res;
        }

        static void CheckOverflow(int[] res, int index)
        {
            if (res[index] > 9)
            {
                res[index + 1] += res[index] / 10;
                res[index] = res[index] % 10;
            }
        }
}
