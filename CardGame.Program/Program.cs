using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace CardGame.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Maiken");
            Player player2 = new WeakPlayer("Nicklas");
            Player player3 = new Player("Mikkel");
            Deck mydeck = new Deck();
            Game newGame = new LowWinnerGame(mydeck);
            newGame.AcceptPlayerToGame(player1);
            newGame.AcceptPlayerToGame(player2);
            newGame.AcceptPlayerToGame(player3);
            newGame.DealCards(5);
            player1.ShowHand();
            Console.WriteLine("Total value of hand: {0}",player1.TotalValueOfHand());
            player2.ShowHand();
            Console.WriteLine("Total value of hand: {0}", player2.TotalValueOfHand());
            player3.ShowHand();
            Console.WriteLine("Total value of hand: {0}", player3.TotalValueOfHand());
            newGame.AnnouceWinner();
            Console.ReadKey();


        }
    }
}
