using Core.Contexts.FSM;

namespace AnlautJam.Game.Player
{
    public partial class PlayerStateMediator : StateMachineMediator<PlayerStateMediator, IPlayerView, PlayerModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}