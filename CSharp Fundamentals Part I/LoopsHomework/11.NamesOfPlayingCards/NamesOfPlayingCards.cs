using System;

class NamesOfPlayingCards
{
    static void Main()
    {
        string[] cardsNames = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        string[] cardsSuits = {"Spades", "Hearts", "Diamonds", "Clubs"};

        for (int i = 0; i < cardsSuits.Length; i++)
        {
            for (int j = 0; j < cardsNames.Length; j++)
            {
                Console.WriteLine("{0} of {1}", cardsNames[j], cardsSuits[i]);
            }
            Console.WriteLine();
        }

    }
}

