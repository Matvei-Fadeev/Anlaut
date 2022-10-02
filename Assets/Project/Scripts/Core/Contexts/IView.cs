namespace Core.Contexts
{
    public interface IView<TMediator>
    {
        public TMediator Mediator { get; }
    }
}