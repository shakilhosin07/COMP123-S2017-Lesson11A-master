using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Shakil Hosin
 * Date: July 25, 2017
 * Description: This is the Deck class it inherits from the cardlist class
 * Version: 0.7 -Changed the deal5 method to type hand because it has to be passed through the highest card method as a hand.
 */

namespace COMP123_S2017_Lesson11A
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random {
            get
            {
                return this._random;
            }

        }

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards.
        /// This method also initializes other class variables
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random object
            this._random = new Random();

            // load the list with cards
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method and outputs the current contents
        /// of the deck.
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Deck Contains:\n";
            outputString += "==============================================================================\n";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
        /// <summary>
        /// This method removes a card from element 0 in the list and returns this card. 
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {

            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); //This Removes the top card
            //Console.WriteLine("Deck Contains: " + this.Count + " Cards");

            return firstCard;
        }
        
        public Hand Deal5()
        {

            Hand hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                hand.Add(Deal1());
            }
            Console.WriteLine("Deck Contains: " + this.Count + " Cards");
            Console.WriteLine(hand);
            return hand;
        }
    }
}