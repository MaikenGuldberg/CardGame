using System;

namespace CardGame
{
    public class LowWinnerGame : Game
    {
        public LowWinnerGame(Deck deck) : base(deck)
        {
        }

        public override void AnnouceWinner()
        {
            string winner = base._players[0]._name;
            int winnerScoor = base._players[0].TotalValueOfHand();
            foreach (var player in base._players)
            {
                if (player.TotalValueOfHand() < winnerScoor || player.TotalValueOfHand() == winnerScoor)
                {
                    winner = player._name;
                    winnerScoor = player.TotalValueOfHand();
                }
            }
            Console.WriteLine("The winner is: " + winner);
        }
    }
}