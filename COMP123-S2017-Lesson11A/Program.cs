﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Shakil Hosin
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.4 - Tested the deal method, updated the program class to include comments for the Lab25
 */

namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand();// new empty hand container;

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            //hand = deck. deal5
            /*
            hand.Add(deck.Deal1());// deal one card from the top of the deck
            Console.WriteLine(hand.ToString());

            hand.Add(deck.Deal1());// deal one card from the top of the deck
            Console.WriteLine(hand.ToString());

            hand.Add(deck.Deal1());// deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */
             
            // hand = deck.deal5(); //creates a new hand obkect and assigns it to hand. 
        }
    }
}
