﻿namespace Stacks_Wilson_Kenny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]
            {
                /// Creates a Card
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Dimaonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Club"),
                new Card("Ace", "Dimaonds"),
            };

            /// Cards stack and push the cards in to the startingDeck.
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);


            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            
            Console.WriteLine("Got any 8's?");
            if (startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

        }

    }
}