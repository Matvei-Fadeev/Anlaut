using Core.Contexts.FSM;
using Project.Scripts.Game.Player.View;

namespace Project.Scripts.Game.Player
{
    public partial class PlayerStateMediator : StateMachineMediator<PlayerStateMediator, IPlayerView, PlayerModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}