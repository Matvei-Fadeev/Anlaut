using System;
using Zenject;

namespace Core.Installers
{
    public class CoreSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CoreSceneInstaller>().FromInstance(this);
        }
        

        public void OnNewValidOpenState(Type openState)
        {
        }
    }
}
