using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
   public  class Deck:List<Card>
    {
        //private variables
        //public properties
        //constructors
        /// <summary>
        /// main constructor for deck class
        /// </summary>
        public Deck()
        {
            this._initialise();
        }
        // private methods
        /// <summary>
        /// this is initialise method it sets value for private variables and public properties.
        /// </summary>
        private void _initialise()
        {
            for  (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }
        //public methods
        public override string ToString()
        {
            String outputString="";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }


    }
}
