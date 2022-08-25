using Core.SceneLoader;
using Zenject;

namespace Core.Installers
{
    public class CoreContextInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            SceneContextInstaller.Install(Container);
            PromiseContextInstaller.Install(Container);
        }
    }
}