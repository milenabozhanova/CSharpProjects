using System;

class Problem1_ShipDamage
{
    static void Main()
    {
        int ship1x = int.Parse(Console.ReadLine());
        int ship1y = int.Parse(Console.ReadLine());
        int ship2x = int.Parse(Console.ReadLine());
        int ship2y = int.Parse(Console.ReadLine());
        int hor = int.Parse(Console.ReadLine());
        int c1x = int.Parse(Console.ReadLine());
        int c1y = int.Parse(Console.ReadLine());
        int c2x = int.Parse(Console.ReadLine());
        int c2y = int.Parse(Console.ReadLine());
        int c3x = int.Parse(Console.ReadLine());
        int c3y = int.Parse(Console.ReadLine());

        ship1y -= hor;
        ship2y -= hor;
        c1y -= hor;
        c2y -= hor;
        c3y -= hor;

        int[] reflectedCY = { -c1y, -c2y, -c3y };
        int[] reflectedCX = { c1x, c2x, c3x };

        int top = Math.Max(ship1y, ship2y);
        int left = Math.Min(ship1x, ship2x);
        int right = Math.Max(ship1x, ship2x);
        int bottom = Math.Min(ship1y, ship2y);

        int sum = 0;

        for (int i = 0; i < reflectedCY.Length; i++)
        {
            if (reflectedCY[i] < top && reflectedCY[i] > bottom)
            {
                if (reflectedCX[i] < right && reflectedCX[i] > left)
                {
                    sum += 100;
                }
                else if (reflectedCX[i] == right || reflectedCX[i] == left)
                {
                    sum += 50;
                }

            }
            else if (reflectedCY[i] == top || reflectedCY[i] == bottom)
            {
                if (reflectedCX[i] < right && reflectedCX[i] > left)
                {
                    sum += 50;
                }
                else if (reflectedCX[i] == right || reflectedCX[i] == left)
                {
                    sum += 25;
                }
            }
        }
        

        Console.WriteLine(sum + "%");
    }
}


