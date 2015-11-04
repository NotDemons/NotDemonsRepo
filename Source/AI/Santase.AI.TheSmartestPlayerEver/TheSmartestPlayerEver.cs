using Santase.Logic.Players;
using System;

namespace Santase.AI.TheSmartestPlayerEver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Logic.Players;
    using Logic.Cards;

    public class TheSmartestPlayerEver : BasePlayer
    {
        private readonly ICollection<Card> playedCards = new List<Card>();

        private readonly OpponentSuitCardsProvider opponentSuitCardsProvider = new OpponentSuitCardsProvider();

        public override string Name => "Smart Player";

        public override PlayerAction GetTurn(PlayerTurnContext context)
        {
            throw new NotImplementedException();
        }
    }
}
