using System;
using System.Collections.Generic;
using System.Linq;

class SimpleMathematicalProblems
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose number of a task:");
        Console.WriteLine("1). Reverse the digits of a number");
        Console.WriteLine("2). Calculate the avarage of a sequence of integers");
        Console.WriteLine("3). Solve a linear equation: a * x + b = 0");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Task 1). Reversing of digits:");
            Console.Write("Please enter a number (n > 0): ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                int reversed = ReverseDigits(num);
                Console.WriteLine("The reversed number is: {0}", reversed);
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Task 2) Calculatation of average:");
            Console.Write("Enter length of the sequence (length > 0): ");
            int len = int.Parse(Console.ReadLine());

            if (len <= 0)
            {
                Console.WriteLine("Invalid lenght.");
            }
            else
            {
                int[] numbers = new int[len];
                Console.WriteLine("Please enter the elements of the sequence (each of a new line):");

                for (int i = 0; i < len; ++i)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int average = CalcAverage(numbers);
                Console.WriteLine("The average is: {0}", average);
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Task 3) Solution of a linear equation:");
            Console.WriteLine("Please enter the coefficients (a and b) of the equation:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0.0)
            {
                Console.WriteLine("Invalid input for a");
            }
            else
            {
                double result = SolveEquation(a, b);
                Console.WriteLine("x = {0}", result);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
    
    static int ReverseDigits(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed = (reversed * 10) + (num % 10);
            num /= 10;
        }
        return reversed;
    }

    static int CalcAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / 2;
    }

    static double SolveEquation(double a, double b)
    {
        double result = -b / a;
        return result;
    }
}