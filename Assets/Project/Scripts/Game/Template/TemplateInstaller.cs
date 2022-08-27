using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.Template
{
    public class TemplateInstaller : ContextInstaller<TemplateStateMediator, ITemplateView, TemplateModel>
    {
        [SerializeField] private TemplateView templateView;

        protected override ITemplateView View => templateView;
    }
}