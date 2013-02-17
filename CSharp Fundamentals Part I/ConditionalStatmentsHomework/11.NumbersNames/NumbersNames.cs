using System;

class NumbersNames
{
    static void Main()
    {

        int[] numbers = new int[1000];

        string[] namesZeroToNineteen = new string[20] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        string[] nameTens = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        Console.WriteLine("Please enter a number (0-999): ");
        int num = int.Parse(Console.ReadLine());

        if (num < 20)
        {
            Console.WriteLine("{0} - {1}", num, namesZeroToNineteen[num]);
        }
         else if (num > 19 && num < 100)
        {
            if (num % 10 == 0)
            {
                Console.WriteLine("{0} - {1}", num, nameTens[num/ 10]);
            }
            else
            {
                Console.WriteLine("{0} - {1}-{2}", num, nameTens[num/ 10], namesZeroToNineteen[num% 10]);
            }
        }
        else if (num> 99 && num< 1000)
        {
            if (num% 100 == 0)
            {
                Console.WriteLine("{0} - {1} hundred", num, namesZeroToNineteen[num/ 100]);
            }
            else if (num% 100 < 20)
            {
                Console.WriteLine("{0} - {1} hundred and {2}",num, namesZeroToNineteen[num/ 100], namesZeroToNineteen[num% 100]);
            }
            else
            {
                int tensCheck = num% 100;

                if (tensCheck % 10 == 0)
                {
                    Console.WriteLine("{0} - {1} hundred and {2}", num, namesZeroToNineteen[num/ 100], nameTens[tensCheck / 10]);
                }
                else
                {
                    Console.WriteLine("{0} - {1} hundred (and) {2}-{3}", num, namesZeroToNineteen[num/ 100], nameTens[tensCheck / 10], namesZeroToNineteen[tensCheck % 10]);
                }
            }
        }
    }
}

