using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 25, 2017
 * Description: this is the abstract superclass CardList 
 * It inherits from the built-in list generic collection and consumes the card class.
 * Version: 0.1 - Created the abstract class CardList
 */

namespace COMP123_S2017_Lesson11A
{
    public abstract class CardList : List<Card>
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }
        //PRIVATE METHODS(IF ANY)
        /// <summary>
        /// It's a private method that we want to override.
        /// </summary>
        protected abstract void _initialize();
        //PUBLIC METHODS(IF ANY)
    }
}