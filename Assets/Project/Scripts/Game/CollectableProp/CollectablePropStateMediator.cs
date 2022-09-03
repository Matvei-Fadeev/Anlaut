using Core.Contexts.FSM;

namespace AnlautJam.Game.CollectableProp
{
    public partial class CollectablePropStateMediator : StateMachineMediator<CollectablePropStateMediator, ICollectablePropView, CollectablePropModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}