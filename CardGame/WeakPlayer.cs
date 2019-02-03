namespace CardGame
{
    public class WeakPlayer : Player
    {
        public WeakPlayer(string name) : base(name)
        {

        }

        public override void AddCardToHand(Card card)
        {
            if (base._hand.Count==3)
            {
                base._hand.RemoveAt(0);
            }
            base._hand.Add(card);
        }
    }
}