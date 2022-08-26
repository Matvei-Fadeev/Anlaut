using System;
using UniRx;
using Zenject;

namespace Core.Contexts
{
    public class Mediator : IInitializable, ITickable, IDisposable
    {
        protected CompositeDisposable Disposables;

        [Inject] protected SignalBus SignalBus;

        public virtual void Initialize()
        {
            Disposables = new CompositeDisposable();
        }

        public virtual void Tick()
        {
        }

        public virtual void Dispose()
        {
            Disposables.Dispose();
        }
    }
}