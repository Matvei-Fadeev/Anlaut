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

        public sealed override void InstallBindings()
        {
            InstallBindings(Container);
        }

        public virtual void InstallBindings(DiContainer diContainer)
        {
            InstallBindings(diContainer, View);
        }

        public static void InstallBindings(DiContainer diContainer, TView view, TModel currencyModel)
        {
            // TODO InstallBindings(diContainer, View); can't be called here
            diContainer.BindInstance(currencyModel);
            InstallBindings(diContainer, view);
        }

        public static void InstallBindings(DiContainer diContainer, TView view)
        {
            // TODO InstallBindings(diContainer, View); can't be called here
            if (!diContainer.HasBinding<TModel>())
                diContainer.Bind<TModel>().AsSingle();
            diContainer.Bind<TView>().FromInstance(view);
            diContainer.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}