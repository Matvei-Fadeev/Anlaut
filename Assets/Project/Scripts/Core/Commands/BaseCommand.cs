using Zenject;

namespace Project.Scripts.Core.Commands
{
    public abstract class BaseCommand
    {
        [Inject] protected SignalBus SignalBus;
    }
}