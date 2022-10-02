using UnityEngine;
using Zenject;

namespace Jam.Game.CurrencyHolder
{
    public class PlayerCurrencyHolderView : MonoBehaviour, ICurrencyHolderView
    {
        public ICurrencyHolderMediator Mediator { get; private set; }
        
        [Inject]
        private void Construct(ICurrencyHolderMediator mediator)
        {
            Mediator = mediator;
        }
    }
}