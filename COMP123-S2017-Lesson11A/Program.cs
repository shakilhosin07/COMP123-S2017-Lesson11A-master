using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Shakil Hosin
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.5 - Tested the deal5 method which was made in the deck class
 */

namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand();// new empty hand container;

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString()+"\n");
            deck.Shuffle();
            Console.WriteLine(deck.ToString()+"\n");

            //hand = deck.deal5()
            /*
            hand.Add(deck.Deal1());// deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */

            // hand = deck.deal5(); //creates a new hand object and assigns it to hand. 

            //Dealing 5 cards 

            deck.Deal5();
         
 
    }
        
    }
}
