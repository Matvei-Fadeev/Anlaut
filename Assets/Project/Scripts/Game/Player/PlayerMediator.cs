using Core.Contexts;
using Project.Scripts.Game.Player.View;

namespace Project.Scripts.Game.Player
{
    public class PlayerMediator : Mediator<IPlayerView, PlayerModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}