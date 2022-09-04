using System;
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
            InstallBindings(Container, View);
            InstallBindings(Container);
        }

        public virtual void InstallBindings(DiContainer diContainer)
        {
        }

        public static void InstallBindings(DiContainer diContainer, TView view, TModel currencyModel)
        {
            diContainer.BindInstance(currencyModel);
            InstallBindings(diContainer, view);
        }

        public static void InstallBindings(DiContainer diContainer, TView view)
        {
            if (!diContainer.HasBinding<TModel>())
                diContainer.Bind<TModel>().AsSingle();
            diContainer.Bind<TView>().FromInstance(view);
            diContainer.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}