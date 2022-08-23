using System;
using Zenject;

namespace Project.Scripts.Core.Installers
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
