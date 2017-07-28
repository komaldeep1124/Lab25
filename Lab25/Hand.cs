using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
        }

        internal void Add(object v)
        {
            throw new NotImplementedException();
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        public void HighestCards(Hand hand)
        {
            var sortedHand = from cards in hand
                             orderby cards.Face descending
                             select cards.Face;
            Console.WriteLine("Highest cards in descending order: ");
            foreach (var item in sortedHand)
            {
                {
                    Console.WriteLine(item);
                }


            }

        }
    }
}
    