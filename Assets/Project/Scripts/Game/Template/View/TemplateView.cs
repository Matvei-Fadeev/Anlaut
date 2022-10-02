using UnityEngine;
using Zenject;

namespace Jam.Game.Template
{
    public class TemplateView : MonoBehaviour, ITemplateView
    {
        public ITemplateMediator Mediator { get; private set; }
        
        [Inject]
        private void Construct(ITemplateMediator mediator)
        {
            Mediator = mediator;
        }
    }
}