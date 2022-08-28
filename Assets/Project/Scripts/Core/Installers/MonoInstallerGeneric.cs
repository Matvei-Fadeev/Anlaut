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
            InstallBindings(Container, View);
        }

        public static void InstallBindings(DiContainer diContainer, TView view)
        {
            diContainer.Bind<TModel>().AsSingle();
            diContainer.Bind<TView>().FromInstance(view);
            diContainer.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}