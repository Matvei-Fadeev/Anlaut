using Core.Contexts;

namespace Jam.Game.Template
{
    public interface ITemplateMediator
    {
    }

    public class TemplateMediator : Mediator<ITemplateView, TemplateModel>, ITemplateMediator
    {
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}