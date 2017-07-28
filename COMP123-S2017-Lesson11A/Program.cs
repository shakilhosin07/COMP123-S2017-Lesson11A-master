using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Shakil Hosin
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.6 - Creating a new hand object to deal 5 cards to
 */

namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand();// new empty hand container;

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString() + "\n");
            deck.Shuffle();
            Console.WriteLine(deck.ToString() + "\n");

            //hand = deck.deal5()
            /*
            hand.Add(deck.Deal1());// deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */

            // hand = deck.deal5(); //creates a new hand object and assigns it to hand. 

            //Creating a new hand object to deal 5 cards to
            Hand h2 = new Hand();
            h2 = deck.Deal5();
            
            //passing the new object through the highest card method
            
            Hand.HighestCard(h2);

    
            

        }
    }
}
