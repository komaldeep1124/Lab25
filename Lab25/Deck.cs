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
        private Random _random;
            //private properties
            private Random Random
        {
            get { return this._random; }
        }
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
            this._random = new Random();
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
            outputString += "Deck Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
        public void shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;
            for (int card = 0; card < this.Count; card++)
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


    }
}
