using Core.Contexts.FSM;

namespace Jam.Game.CurrencyHolder
{
    public partial class CurrencyHolderStateMediator : StateMachineMediator<CurrencyHolderStateMediator, ICurrencyHolderView, CurrencyHolderModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}