using Core.Contexts;
using Zenject;

namespace Core.Installers
{
    public abstract class
        MonoInstaller<TMediator, TView, TModel> : MonoInstaller
        where TMediator : Mediator
        where TModel : class
    {
        protected abstract TView View { get; }

        public override void InstallBindings()
        {
            Container.Bind<TModel>().AsSingle();
            Container.Bind<TView>().FromInstance(View);
            Container.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}