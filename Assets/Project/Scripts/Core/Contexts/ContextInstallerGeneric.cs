using Core.Contexts;
using Zenject;

namespace Core.Installers
{
    public abstract class ContextInstaller<TMediator, TView, TModel> : MonoInstaller
        where TMediator : Mediator
        where TModel : class
    {
        protected abstract TView View { get; }
        
        public override void InstallBindings()
        {
            Container.Bind<TModel>().AsSingle();
            Container.Bind<TView>().FromInstance(View);
            Container.BindInterfacesTo<TMediator>().AsSingle();
        }
    }
}