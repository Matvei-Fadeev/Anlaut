using Zenject;

namespace Core.Contexts.FSM
{
    public class StateMachineMediator<TMediator, TView, TModel> : StateMachineMediator
        where TMediator : StateMachineMediator<TMediator, TView, TModel>
        where TModel : class
    {
        public class State : StateBehaviour
        {
            protected readonly TMediator StateMediator;
            protected readonly TModel Model;
            protected readonly TView View;
            
            public State(TMediator stateMediator) : base(stateMediator)
            {
                StateMediator = stateMediator;
                Model = stateMediator.Model;
                View = stateMediator.View;
            }
        }
        
        [Inject] protected readonly TView View;
        [Inject] protected readonly TModel Model;
    }
}