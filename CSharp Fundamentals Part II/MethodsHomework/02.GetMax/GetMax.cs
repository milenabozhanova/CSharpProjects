using System;

class GetMax
{
    static float GetMaxOfTwo(float number1, float number2)
    {
        float max = number1;
        if (number2 > number1)
            max = number2;
        return max;
    }


    static void Main()
    {
        Console.WriteLine("Please enter 3 numbersq each on a new line:");
        float firstNum = float.Parse(Console.ReadLine());
        float secoundNum = float.Parse(Console.ReadLine());
        float thirdNum = float.Parse(Console.ReadLine());
    
        float middleNum = GetMaxOfTwo(firstNum, secoundNum);
        
        Console.WriteLine("Maximal number: {0}", GetMaxOfTwo(middleNum, thirdNum));
    }
}
