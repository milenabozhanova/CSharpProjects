using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number in the range: 1 - 9:");

        string enteredNumber = Console.ReadLine();
        ushort number = 0;
        bool isNumber = ushort.TryParse(enteredNumber, out number);
        if (isNumber == true)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Invalid number");
                    break;
                case 1:
                case 2:
                case 3:
                    number *= 10;
                    Console.WriteLine("Your scoure with the bonus is: {0}", number);
                    break;

                case 4:
                case 5:
                case 6:
                    number *= 100;
                    Console.WriteLine("Your scoure with the bonus is: {0}", number);
                    break;

                case 7:
                case 8:
                case 9:
                    number *= 1000;
                    Console.WriteLine("Your scoure with the bonus is: {0}", number);
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

