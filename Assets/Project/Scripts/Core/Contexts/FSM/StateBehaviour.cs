using UniRx;
using UnityEngine;
using Zenject;

namespace Core.Contexts.FSM
{
    public partial class StateMachineMediator
    {
        public class StateBehaviour
        {
            protected CompositeDisposable Disposables;
            protected readonly SignalBus SignalBus;

            public StateBehaviour(StateMachineMediator stateMediator)
            {
                SignalBus = stateMediator.SignalBus;
            }

            public virtual void OnStateEnter()
            {
                Debug.Log(string.Format("{0} , OnStateEnter()", this));

                Disposables = new CompositeDisposable();
            }

            public virtual void OnStateExit()
            {
                Debug.Log(string.Format("{0} , OnStateExit()", this));

                Disposables.Dispose();
            }

            public virtual bool IsValidOpenState()
            {
                return false;
            }

            public virtual void Tick()
            {

            }
        }
    }
}
