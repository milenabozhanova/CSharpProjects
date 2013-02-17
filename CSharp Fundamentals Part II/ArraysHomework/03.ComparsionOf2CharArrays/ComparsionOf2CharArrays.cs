using System;

class ComparsionOf2CharArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the lenght of the arrays n: ");
        int n = int.Parse(Console.ReadLine());
        char[] arr1 = new char[n];
        char[] arr2 = new char[n];

        Console.WriteLine("Please enter {0} chars - each of new line", n);

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter another {0} integers for the secound array - each of new line", n);

        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = char.Parse(Console.ReadLine());
        }

        //comparsion of the arrays
        bool areEqual = true;

        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                areEqual = false;
                break;
            }
        }
        Console.WriteLine(areEqual ? "The arrays are equal" : "The arrays aren't equal");
    }
}

