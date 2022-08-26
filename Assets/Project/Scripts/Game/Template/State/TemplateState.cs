namespace AnlautJam.Game.Template
{
    public partial class TemplateMediator
    {
        public class TemplateState : StateBehaviour
        {
            protected readonly TemplateMediator Mediator;
            protected readonly TemplateModel Model;
            protected readonly ITemplateView View;
            
            public TemplateState(TemplateMediator mediator) : base(mediator)
            {
                Mediator = mediator;
                Model = mediator._templateModel;
                View = mediator._templateView;
            }
        }
    }
}