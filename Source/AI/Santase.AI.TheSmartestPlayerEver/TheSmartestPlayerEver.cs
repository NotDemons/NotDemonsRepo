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

        public override string Name => "The Smartest Player Ever";

        public override PlayerAction GetTurn(PlayerTurnContext context)
        {
            // When possible change the trump card as this is almost always a good move
            // Changing trump can be non-optimal when:
            // 1. Current player is planning to close the game and don't want to give additional points to his opponent
            // 2. The player will close the game and you will give him additional points by giving him bigger trump card instead of 9
            // 3. Want to confuse the opponent
            if (this.PlayerActionValidator.IsValid(PlayerAction.ChangeTrump(), context, this.Cards))
            {
                return this.ChangeTrump(context.TrumpCard);
            }

            if (this.CloseGame(context))
            {
                return this.CloseGame();
            }

            return this.ChooseCard(context);
        }

        private PlayerAction ChooseCard(PlayerTurnContext context)
        {
            throw new NotImplementedException();
        }

        private bool CloseGame(PlayerTurnContext context)
        {
            throw new NotImplementedException();
        }
    }
}
