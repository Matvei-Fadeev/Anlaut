using UnityEngine;
using Zenject;

namespace Jam.Game.Template
{
    public class TemplateInstaller : Core.Installers.MonoInstaller<TemplateMediator, ITemplateView, TemplateModel>
    {
        [SerializeField] private TemplateView templateView;

        protected override ITemplateView View => templateView;
    }
}