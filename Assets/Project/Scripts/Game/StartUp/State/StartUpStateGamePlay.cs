namespace AnlautJam.Game.StartUp
{
    public partial class StartUpMediator
    {
        public class StartUpStateGamePlay : State
        {
            public StartUpStateGamePlay(StartUpMediator mediator) : base(mediator)
            {
            }

            public override void OnStateEnter()
            {
                base.OnStateEnter();
                View.Hide();
            }
        }
    }
}