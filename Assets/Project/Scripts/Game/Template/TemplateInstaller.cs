using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Template
{
    public class TemplateInstaller : MonoInstaller
    {
        [SerializeField] private TemplateView TemplateView;

        public override void InstallBindings()
        {
            Container.Bind<TemplateModel>().AsSingle();
            Container.BindInstance(TemplateView);
            Container.BindInterfacesTo<TemplateMediator>().AsSingle();
        }
    }
}