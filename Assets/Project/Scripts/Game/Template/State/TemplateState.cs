namespace Jam.Game.Template
{
    public partial class TemplateStateMediator
    {
        public class TemplateState : State
        {
            public TemplateState(TemplateStateMediator stateMediator) : base(stateMediator)
            {
            }
        }
    }
}