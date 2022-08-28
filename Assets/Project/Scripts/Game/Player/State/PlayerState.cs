namespace AnlautJam.Game.Player
{
    public partial class PlayerStateMediator
    {
        public class PlayerState : State
        {
            public PlayerState(PlayerStateMediator stateMediator) : base(stateMediator)
            {
            }
        }
    }
}