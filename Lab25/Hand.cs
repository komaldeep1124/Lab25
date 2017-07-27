using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
   public  class Hand : CardList
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
}
}
