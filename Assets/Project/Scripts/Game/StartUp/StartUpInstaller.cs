using UnityEngine;
using Zenject;

namespace Jam.Game.StartUp
{
    public class StartUpInstaller : MonoInstaller
    {
        [SerializeField] private StartUpView StartUpView;

        public override void InstallBindings()
        {
            Container.Bind<StartUpModel>().AsSingle();
            Container.BindInstance(StartUpView);
            Container.BindInterfacesTo<StartUpMediator>().AsSingle();
        }
    }
}