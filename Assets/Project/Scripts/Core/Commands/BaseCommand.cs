using Zenject;

namespace Core.Commands
{
    public abstract class BaseCommand
    {
        [Inject] protected SignalBus SignalBus;
    }
}