using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IsCorrectExpression
{
    static void Main()
    {
        string expression = Console.ReadLine();

        int cnt = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if(expression[i] == '(')
            {
                cnt++;
            }
            else if (expression[i] == ')')
            {
                cnt--;
            }
            if (cnt < 0)
            {
                break;
            }
        }

        if (cnt == 0)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("The expression is incorrect");
        }
    }
}
