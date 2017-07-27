using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
    //name:komaldeep akur
    //student no:300926834
{
   public  class Card
    {
            //private instance variables
             private Face _face;
             private Suit _suit;
             //public properties
             public Face Face
        {
            get { return this._face; }
            set { this._face = value; }
        }
        public Suit Suit
        {
            get { return this._suit; }
            set { this._suit = value; }
        }
        //constructor---
        /// <summary>
        /// this is main constructor.
        /// two paras:face and suit.
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

    }
}
