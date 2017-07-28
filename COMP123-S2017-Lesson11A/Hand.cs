using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson11A
{
    /*
 * Name: Shakil Hosin
 * Date: July 27th, 2017
 * Description: This is the hand class
 * It inherits from the built-in Cardlist generic collection and consumes the card class.
 * Version: 0.1 - Added the deal1 method
 */
    public class Hand : CardList
    {
        //Private instance variables


        //public properties

        //constructors 


        //private methods
        /// <summary>
        /// This method initializes CLASS VARIABLES and other objects
        /// </summary>
        protected override void _initialize()
        {
            //This method is currently empty
        }

        //public methods
        /// <summary>
        /// Taking in a hand object and passing it through the linq
        /// </summary>
        /// <param name="hand"></param>
        public static void HighestCard(Hand hand)
        {

            Card Highest = new Card((Face)0, (Suit)1);

            for (int i = 0; i < 5; i++)
            {
                if (hand[i].Face >= Highest.Face)
                {
                    Highest = hand[i];
                }
            }
            //taking the highest card from the current hand.
            var Highestcard = from High_card in hand where High_card.Face == Highest.Face select High_card;

            foreach (var item in Highestcard)
            {
                Console.WriteLine("The highest card in current hand is the {0} of {1}", item.Face, item.Suit);
            }


        }
        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand Contains:\n";
            outputString += "==============================================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}

 