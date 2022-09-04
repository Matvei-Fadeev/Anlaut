using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Template
{
    public class TemplateInstaller : Core.Installers.MonoInstaller<TemplateMediator, ITemplateView, TemplateModel>
    {
        [SerializeField] private TemplateFacade templateFacade;

        protected override ITemplateView View => templateFacade.TemplateView;

        public override void InstallBindings(DiContainer diContainer)
        {
            base.InstallBindings(diContainer);
        }
    }
}