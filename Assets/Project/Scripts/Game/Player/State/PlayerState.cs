using Core.Contexts.FSM;
using Project.Scripts.Game.Player.View;

namespace Project.Scripts.Game.Player.State
{
    public partial class PlayerStateMediator
    {
        public class PlayerState : StateMachineMediator<Player.PlayerStateMediator, IPlayerView, PlayerModel>.State
        {
            public PlayerState(Player.PlayerStateMediator stateMediator) : base(stateMediator)
            {
            }
        }
    }
}