using Core.Contexts.FSM;
using Zenject;

namespace AnlautJam.Game.Template
{
    public partial class TemplateMediator : StateMachineMediator
    {
        [Inject] private readonly ITemplateView _templateView;
        [Inject] private readonly TemplateModel _templateModel;

        public override void Initialize()
        {
            base.Initialize();
        }
    }
}