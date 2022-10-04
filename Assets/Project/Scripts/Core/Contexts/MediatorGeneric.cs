using Zenject;

namespace Core.Contexts
{
    public class Mediator<TView, TModel> : Mediator
        where TModel : class
    {
        [Inject] protected TView View;
        [Inject] protected TModel Model;
    }
}