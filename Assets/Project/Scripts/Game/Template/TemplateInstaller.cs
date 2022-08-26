using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Template
{
    public class TemplateInstaller : MonoInstaller
    {
        [SerializeField] private TemplateView templateView;

        public override void InstallBindings()
        {
            Container.Bind<TemplateModel>().AsSingle();
            Container.Bind<ITemplateView>().FromInstance(templateView);
            Container.BindInterfacesTo<TemplateMediator>().AsSingle();
        }
    }
}