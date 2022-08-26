using Core.Contexts.FSM;

namespace AnlautJam.Game.Movement
{
    public partial class MovementMediator
    {
        public class MovementState : StateMachineMediator.StateBehaviour
        {
            protected readonly MovementMediator Mediator;
            protected readonly MovementModel Model;
            protected readonly IMovementView View;
            
            public MovementState(MovementMediator mediator) : base(mediator)
            {
                Mediator = mediator;
                Model = mediator._movementModel;
                View = mediator._movementView;
            }
        }
    }
}