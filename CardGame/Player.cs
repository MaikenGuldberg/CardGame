using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Player
    {
        public string _name { get; }
        protected List<Card> _hand;
            
        public Player(string name)
        {
            _name = name;
            _hand = new List<Card>();
        }

        

        public virtual void AddCardToHand(Card card)
        {
            _hand.Add(card);
        }

        public int TotalValueOfHand()
        {
            int totalValue = 0;
            foreach (var card in _hand)
            {
                totalValue = totalValue + card.GetColour() * card.GetNumber();
            }

            return totalValue;
        }

        public void ShowHand()
        {
            Console.WriteLine(_name + " hand:");
            foreach (var card in _hand)
            {
                Console.WriteLine(card.ToString());
            }
        }

    }
}