using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] votes = new int[n];

        // the number of the cat,  cat1 = cats[0]
        int[] cats = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
  

        int max = 0;
        int numberOfCat = 0;

        //input and add point to the vote in cats
        for (int i = 0; i < n; i++)
        {
            votes[i] = int.Parse(Console.ReadLine());
            switch (votes[i])
            {
                case 1: cats[0]++; break;
                case 2: cats[1]++; break;
                case 3: cats[2]++; break;
                case 4: cats[3]++; break;
                case 5: cats[4]++; break;
                case 6: cats[5]++; break;
                case 7: cats[6]++; break;
                case 8: cats[7]++; break;
                case 9: cats[8]++; break;
                case 10: cats[9]++; break;
            }
        }

        //chack which cat has max points
        for (int i = 0; i < cats.Length; i++)
        {
            if (cats[i] > max)
            {
                max = cats[i];
                numberOfCat = i;
            } 
            else if (max == cats[i])
            {
                if ( cats[i] < max)
                {
                    max = cats[i];
                    numberOfCat = i;
                }
            }
        }
        Console.WriteLine(numberOfCat+1);
    }
}

