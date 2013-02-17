using System;

namespace FighterAttack
{
    class FighterAttack
    {
        static void Main()
        {
            int pX1,pY1;
            int pX2,pY2;
            int fX,fY;
            int dist;
            int dmg = 0;

            pX1 = int.Parse(Console.ReadLine());
            pY1 = int.Parse(Console.ReadLine());
            
            pX2 = int.Parse(Console.ReadLine());
            pY2 = int.Parse(Console.ReadLine());

            fX = int.Parse(Console.ReadLine());
            fY = int.Parse(Console.ReadLine());

            dist = int.Parse(Console.ReadLine());

            if (pX1 > pX2)
            {
                int tmp = pX2;
                pX2 = pX1;
                pX1 = tmp;
            }

            if (pY1 < pY2)
            {
                int tmp = pY2;
                pY2 = pY1;
                pY1 = tmp;
            }


            int hitX = fX + dist;
            int hitY = fY;

            if (hitX >= pX1 && hitX <= pX2 && hitY >= pY2 && hitY <= pY1)
            {
                dmg += 100;
            }

            hitX += 1;
            if (hitX >= pX1 && hitX <= pX2 && hitY >= pY2 && hitY <= pY1)
            {
                dmg += 75;
            }

            hitX -= 1;
            hitY -= 1;
            if (hitX >= pX1 && hitX <= pX2 && hitY >= pY2 && hitY <= pY1)
            {
                dmg += 50;
            }

            hitY += 2;
            if (hitX >= pX1 && hitX <= pX2 && hitY >= pY2 && hitY <= pY1)
            {
                dmg += 50;
            }

            Console.WriteLine("{0}%", dmg);
        }
    }
}
