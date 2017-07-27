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