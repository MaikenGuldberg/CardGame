using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Game
    {
        protected List<Player> _players;
        private Deck _deck;

        public Game(Deck deck)
        {
            _deck = deck;
            _players = new List<Player>();
        }

        public void AcceptPlayerToGame(Player player)
        {
            _players.Add(player);
            Console.WriteLine(player._name + " has entered the game!!");
        }

        public void DealCards(int numberOfCardsPrPlayer)
        {
            Console.WriteLine("Dealing cards...");
            foreach (var player in _players)
            {
                _deck.DealCard(numberOfCardsPrPlayer,player);
            }
            Console.WriteLine("Cards are deald!! let the game begin!!");
        }

        public virtual void AnnouceWinner()
        {
            string winner = "no winner";
            int winnerScoor = 0;
            foreach (var player in _players)
            {
                if (player.TotalValueOfHand() > winnerScoor|| player.TotalValueOfHand() == winnerScoor)
                {
                    winner = player._name;
                    winnerScoor = player.TotalValueOfHand();
                }
            }
            Console.WriteLine("The winner is: " + winner);
        }
    }
}