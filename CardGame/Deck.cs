using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Deck
    {
        private List<Card> _cardsInDeck;
        private Random _cardDealer;

        public Deck()
        {
            _cardsInDeck = new List<Card>();
            _cardsInDeck.Add(new Card(Card.Red,1));
            _cardsInDeck.Add(new Card(Card.Red, 2));
            _cardsInDeck.Add(new Card(Card.Red, 3));
            _cardsInDeck.Add(new Card(Card.Red, 4));
            _cardsInDeck.Add(new Card(Card.Red, 5));
            _cardsInDeck.Add(new Card(Card.Red, 6));
            _cardsInDeck.Add(new Card(Card.Red, 7));
            _cardsInDeck.Add(new Card(Card.Red, 8));
            _cardsInDeck.Add(new Card(Card.Blue, 1));
            _cardsInDeck.Add(new Card(Card.Blue, 2));
            _cardsInDeck.Add(new Card(Card.Blue, 3));
            _cardsInDeck.Add(new Card(Card.Blue, 4));
            _cardsInDeck.Add(new Card(Card.Blue, 5));
            _cardsInDeck.Add(new Card(Card.Blue, 6));
            _cardsInDeck.Add(new Card(Card.Blue, 7));
            _cardsInDeck.Add(new Card(Card.Blue, 8));
            _cardsInDeck.Add(new Card(Card.Green, 1));
            _cardsInDeck.Add(new Card(Card.Green, 2));
            _cardsInDeck.Add(new Card(Card.Green, 3));
            _cardsInDeck.Add(new Card(Card.Green, 4));
            _cardsInDeck.Add(new Card(Card.Green, 5));
            _cardsInDeck.Add(new Card(Card.Green, 6));
            _cardsInDeck.Add(new Card(Card.Green, 7));
            _cardsInDeck.Add(new Card(Card.Green, 8));
            _cardsInDeck.Add(new Card(Card.Yellow, 1));
            _cardsInDeck.Add(new Card(Card.Yellow, 2));
            _cardsInDeck.Add(new Card(Card.Yellow, 3));
            _cardsInDeck.Add(new Card(Card.Yellow, 4));
            _cardsInDeck.Add(new Card(Card.Yellow, 5));
            _cardsInDeck.Add(new Card(Card.Yellow, 6));
            _cardsInDeck.Add(new Card(Card.Yellow, 7));
            _cardsInDeck.Add(new Card(Card.Yellow, 8));
            _cardsInDeck.Add(new Card(Card.Gold, 1));
            _cardsInDeck.Add(new Card(Card.Gold, 2));
            _cardsInDeck.Add(new Card(Card.Gold, 3));
            _cardsInDeck.Add(new Card(Card.Gold, 4));
            _cardsInDeck.Add(new Card(Card.Gold, 5));
            _cardsInDeck.Add(new Card(Card.Gold, 6));
            _cardsInDeck.Add(new Card(Card.Gold, 7));
            _cardsInDeck.Add(new Card(Card.Gold, 8));
            _cardDealer = new Random();
        }

        public void DealCard(int numberOfCards, Player player)
        {

            for (int i = 0; i < numberOfCards; i++)
            {
                if (_cardsInDeck.Count != 0)
                {
                    int cardIndex = _cardDealer.Next(0, _cardsInDeck.Count - 1);
                    player.AddCardToHand(_cardsInDeck[cardIndex]);
                    _cardsInDeck.RemoveAt(cardIndex);
                }
                else
                {
                    Console.WriteLine("Not enugh cards: " + player._name + " is missing " + (numberOfCards-i).ToString() + " cards");
                    break;
                }
            }

        }
            
            
        }
    }
