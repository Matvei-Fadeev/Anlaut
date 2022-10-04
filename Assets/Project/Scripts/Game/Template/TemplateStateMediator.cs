using Core.Contexts.FSM;

namespace Jam.Game.Template
{
    public partial class TemplateStateMediator : StateMachineMediator<TemplateStateMediator, ITemplateView, TemplateModel>
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}