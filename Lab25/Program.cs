using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("original deck");
            Console.WriteLine("original card  number of card:" +deck.Count);
            Console.WriteLine("==================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.shuffle();
            Hand.Add(deck.Deal1());
            Console.WriteLine(Hand.ToString());
            Console.WriteLine();
            Hand.Add(deck.Deal1());
            Console.WriteLine(Hand.ToString());
            
           Console.WriteLine();
            Console.WriteLine(deck.ToString());




        }
    }
}
