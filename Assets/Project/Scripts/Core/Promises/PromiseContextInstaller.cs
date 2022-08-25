using Core.Promises;
using Zenject;

namespace Core
{
    public class PromiseContextInstaller : Installer<PromiseContextInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<PromiseLoader>().AsTransient();
        }
    }
}