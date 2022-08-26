using System.Collections.Generic;
using UnityEngine;

namespace Core.Contexts.FSM
{
    public partial class StateMachineMediator : Mediator
    {
        protected StateBehaviour CurrentStateBehaviour;
        protected Dictionary<int, StateBehaviour> StateBehaviours = new Dictionary<int, StateBehaviour>();

        public virtual void GoToState(int stateType)
        {
            if (!StateBehaviours.ContainsKey(stateType))
            {
                Debug.LogError("State Missing in Mediator.");
            }
            else if (CurrentStateBehaviour == null || StateBehaviours[stateType] != CurrentStateBehaviour)
            {
                GoToStateInternal(stateType);
            }
        }

        private void GoToStateInternal(int stateType)
        {
            if (StateBehaviours.ContainsKey(stateType))
            {
                CurrentStateBehaviour?.OnStateExit();
                CurrentStateBehaviour = StateBehaviours[stateType];

                CurrentStateBehaviour.OnStateEnter();
            }
            else
            {
                Debug.LogError($"State Id[{stateType}] doesn't Exist in the Dictionary.");
            }
        }

        public override void Tick()
        {
            base.Tick();
            CurrentStateBehaviour?.Tick();
        }

        public override void Dispose()
        {
            CurrentStateBehaviour?.OnStateExit();
            base.Dispose();
            StateBehaviours.Clear();
        }
    }
}