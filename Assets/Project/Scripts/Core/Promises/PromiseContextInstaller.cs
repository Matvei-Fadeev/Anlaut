using Core.Promises;
using Zenject;

namespace Core
{
    public class PromiseContextInstaller : InstallerBase
    {
        public override void InstallBindings()
        {
            Container.Bind<PromiseLoader>().AsTransient();
        }
    }
}