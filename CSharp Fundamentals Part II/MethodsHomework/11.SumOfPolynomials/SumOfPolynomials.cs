using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumOfPolynomials
{
    class SumOfPolynomials
    {
        static void Main()
        {
            string userInput1 = "3x^3+5x-5x-4";
            string userInput2 = "3x+6";

            SortedList<int, int> func1 = IdentifyCoeficients(userInput1);
            SortedList<int, int> func2 = IdentifyCoeficients(userInput2);

            int max1 = func1.Keys.Max();
            int max2 = func2.Keys.Max();
            int max = (max1 > max2 ? max1 : max2) + 1;
            
            int[] resSum = CalcSum(func1, func2, max);

            Console.WriteLine("The coefficients: {0}", string.Join(" , ", resSum));
        }


        static int[] CalcSum(SortedList<int, int> func1, SortedList<int, int> func2, int max)
        {
            int[] res = new int[max];

            string res2 = string.Empty;
            for (int i = 0; i < max; i++)
            {
                int koef = 0;
                if (func1.Keys.Contains(i))
                {
                    koef += func1[i];
                }
                if (func2.Keys.Contains(i))
                {
                    koef += func2[i];
                }
                res[i] = koef;


                char sign = '+';
                if (koef < 0)
                {
                    sign = '-';
                }
                else if (koef == 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    res2 = string.Format("{2}{0}{1}", koef, res2, sign);
                }
                else if (i == 1)
                {
                    res2 = string.Format("{2}{0}x{1}", koef, res2, sign);
                }
                else
                {
                    res2 = string.Format("{3}{0}x^{1}{2}", koef, i, res2, sign);
                }
            }
            res2 = res2.TrimStart('+');
            Console.WriteLine("The result: {0}", res2);
            return res;
        }

        static SortedList<int, int> IdentifyCoeficients(string userInput)
        {
            SortedList<int, int> res = new SortedList<int, int>();

            string[] parts = GetParts(userInput.ToLower().Replace(" ", ""));

            foreach (string part in parts)
            {
                string[] num = part.Split('^');

                if (num.Length == 1)
                {
                    if (num[0].Contains('x'))
                    {
                        AddValue(res, 1, int.Parse(num[0].Replace("x", "")));
                    }
                    else
                    {
                        AddValue(res, 0, int.Parse(num[0]));
                    }
                }
                else
                {
                    AddValue(res, int.Parse(num[1]), int.Parse(num[0].Replace("x", "")));
                }
            }
            return res;
        }

        static void AddValue(SortedList<int, int> res, int power, int coefficient)
        {
            if (res.ContainsKey(power))
            {
                res[power] += coefficient;
            }
            else
            {
                res.Add(power, coefficient);
            }
        }

        static string[] GetParts(string func)
        {
            List<string> res = new List<string>();

            string part = string.Empty;
            for (int i = 0; i < func.Length; i++)
            {
                if (func[i] == '-' || func[i] == '+')
                {
                    if (part != string.Empty)
                    {
                        res.Add(part);
                    }
                    part = string.Empty;
                }
                part += func[i];
            }
            res.Add(part);

            return res.ToArray();
        }
    }
}
