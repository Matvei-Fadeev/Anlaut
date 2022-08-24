namespace AnlautJam.Game.Template
{
    public partial class TemplateMediator
    {
        public class TemplateState : StateBehaviour
        {
            protected readonly TemplateMediator Mediator;

            public TemplateState(TemplateMediator mediator) : base(mediator)
            {
                Mediator = mediator;
            }
        }
    }
}