using System;

class SumOfSubset
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 integer:");

        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool foundSum = false;

        for (int firstNumber = 0; firstNumber < 4; firstNumber++) //if the sum of 2 of the numbers is 0
        {
            for (int secoundNumber = (firstNumber + 1); secoundNumber < 5; secoundNumber++)
            {
                int sumOfTwo = numbers[firstNumber] + numbers[secoundNumber];
                if (sumOfTwo == 0)
                {
                   Console.WriteLine("({0}) + ({1}) = 0", numbers[firstNumber], numbers[secoundNumber]);
                   foundSum = true;
                }
            }

        }

        for (int firstNumber = 0; firstNumber < 3; firstNumber++) //if the sum of 3 of the numbers is 0
        {
            for (int secoundNumber = (firstNumber + 1); secoundNumber < 5; secoundNumber++)
            {
                for (int thirdNumber = (secoundNumber + 1); thirdNumber < 5; thirdNumber++)
                {
                    int sumOfThree = numbers[firstNumber] + numbers[secoundNumber] + numbers[thirdNumber];
                    if (sumOfThree == 0)
                    {
                        Console.WriteLine("({0}) + ({1}) + ({2}) = 0", numbers[firstNumber], numbers[secoundNumber], numbers[thirdNumber]);
                        foundSum = true;
                    }
                }
            }
        }

        for (int firstNumber = 0; firstNumber < 2; firstNumber++) //if the sum of 4 of the numbers is 0
        {
            for (int secoundNumber = (firstNumber + 1); secoundNumber < 5; secoundNumber++)
            {
                for (int thirdNumber = (secoundNumber + 1); thirdNumber < 5; thirdNumber++)
                {
                    for (int fourthNumber = (thirdNumber + 1); fourthNumber < 5; fourthNumber++)
                    {
                        int sumOfFour = numbers[firstNumber] + numbers[secoundNumber] + numbers[thirdNumber] + numbers[fourthNumber];
                        if (sumOfFour == 0)
                        {
                            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", numbers[firstNumber], numbers[secoundNumber], numbers[thirdNumber], numbers[fourthNumber]);
                            foundSum = true;
                        }
                    }
                }
            }
        }

        if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0) //if the sum of all numbers is 0
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) + ({4}) = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            foundSum = true;
        }
        if (foundSum == false)
        {
            Console.WriteLine("Is not found in a subset of the given numbers that3 whose sum is 0");
        }
    }
}

