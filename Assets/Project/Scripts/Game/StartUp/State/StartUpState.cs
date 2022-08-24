using Core.Contexts.FSM;

namespace AnlautJam.Game.StartUp
{
    public partial class StartUpMediator
    {
        public class StartUpState : StateMachineMediator.StateBehaviour
        {
            protected readonly StartUpMediator Mediator;
            protected readonly StartUpModel Model;
            protected readonly StartUpView View;
            
            public StartUpState(StartUpMediator mediator) : base(mediator)
            {
                Mediator = mediator;
                Model = mediator._startUpModel;
                View = mediator._startUpView;
            }
        }
    }
}